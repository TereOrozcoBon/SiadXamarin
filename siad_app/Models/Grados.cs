using System;
using SQLite;

namespace siad_app.Models
{
    public class GradosModel
    {
        //esto será una tabla que se guardará en el DM
        public GradosModel()
        {
        }


        [PrimaryKey, AutoIncrement]
        public int _id { get; set; }
        public string id { get; set; }
        public string tipo { get; set; }
        public string nombre { get; set; }
    }
}
