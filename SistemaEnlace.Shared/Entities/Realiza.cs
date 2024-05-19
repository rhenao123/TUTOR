using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SistemaEnlace.Shared.Entities
{
    public class Realiza
    {
        public int Id { get; set; }

        public int CodActivi { get; set; }

        public int DniPersona { get; set; }


        [JsonIgnore]
        public Persona persona { get; set; }

        [JsonIgnore]
        public Actividad actividad { get; set; }

    }
}
