using System;
using SQLite;

namespace siad_app.Models
{
    public class Grados
    {
        //esto será una tabla que se guardará en el DM
        public Grados()
        {
        }


        [PrimaryKey, AutoIncrement]
        public int _Id { get; set; }
        public string Id { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public bool Titulado { get; set; }
    }
}
