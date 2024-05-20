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

        public int Idconversacion  { get; set; }

        public string Resumen { get; set; }

        [JsonIgnore]
        public Supervisor supervisors { get; set; }

        public int IdSupervisor { get; set; }



        public int Idfundacion { get; set; }


    }
}
