using System;
using Newtonsoft.Json;

namespace siad_app.Models
{
    public class TutoresModel
    {
        public TutoresModel()
        {
        }

        [JsonProperty("id")] //propiedad como viene en el json de la api
        public string Id { get; set; }

        [JsonProperty("idEmpleado")] //propiedad como viene en el json de la api
        public int IdEmpleado { get; set; }

        [JsonProperty("nombre")]
        public string Nombre { get; set; }

        [JsonProperty("correo")]
        public string Correo { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }
    }
}
