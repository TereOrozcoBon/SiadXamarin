using System;
using SQLite;
using siad_app.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace siad_app.Data
{
    public class GradosDatabase
    {
        public GradosDatabase()
        {
        }

        readonly SQLiteAsyncConnection database;

        public GradosDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Grados>().Wait();
        }

        public Task<List<Grados>> GetGradosAsync()
        {
            return database.Table<Grados>().ToListAsync();
        }

        public Task<Grados> GetGradosAsync(int _id)
        {
            return database.Table<Grados>().Where(i => i._Id == _id).FirstOrDefaultAsync();
        }

        public Task<int> SaveGradoASync(Grados item) { 
            if(item._Id == 0)
            {
                return database.InsertAsync(item);
            }
            else
            {
                return database.UpdateAsync(item);
            } 

        }

        public Task<int> DeleteGradosAsync(Grados item)
        {
            return database.DeleteAsync(item);
        }
    }



}
