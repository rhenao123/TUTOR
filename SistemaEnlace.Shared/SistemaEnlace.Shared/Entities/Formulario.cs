using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SistemaEnlace.Shared.Entities
{
    public class Formulario
    {
        public int Id { get; set; }

        public DateTime Fecha { get; set; }
       
        public string Resumen { get; set; }

        [JsonIgnore]
        public Conversacion conversaciones { get; set; }

        public int Conversacionid { get; set; }

     
        [JsonIgnore]
        public Supervisor supervisores { get; set; }

        public int Supervisorid { get; set; }


        [JsonIgnore]
        public Fundacion fundaciones { get; set; }
        
        public int Fundacionid { get; set; } = 1;

      

    }
}
