using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SistemaEnlace.Shared.Entities
{
    public class Conversacion
    {

        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}",
        ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public DateTime Fecha { get; set; }

        [ForeignKey("JovenVulnerable")]
        public int IdJoven { get; set; }

        [ForeignKey("Tutor")]

        public int IdTutor { get; set; }

        
        
        [JsonIgnore]
        public JovenVulnerable jovenVulnerables { get; set; }


        [JsonIgnore]
        public Tutor tutors { get; set; }

    }

}
