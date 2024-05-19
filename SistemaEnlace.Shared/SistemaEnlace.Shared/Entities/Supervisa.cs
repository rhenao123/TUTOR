using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SistemaEnlace.Shared.Entities
{
    public class Supervisa
    {

        public int Id { get; set; }

        public int CodActi { get; set; }

        public int DniSup { get; set; }


        [JsonIgnore]

        public Supervisor supervisor { get; set; }

        [JsonIgnore]
        public Actividad actividad { get; set; }    

    }
}
