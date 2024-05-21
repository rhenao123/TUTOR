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
    public class JovenVulnerable
    {

        
        public int id { get; set; }




        [Display(Name = "Nombre")]
        [MaxLength(20, ErrorMessage = "No se permiten más de 20 dígitos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Nombre { get; set; }


        [Display(Name = "Apellido")]
        [MaxLength(20, ErrorMessage = "No se permiten más de 20 dígitos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Apellidos { get; set; }

        [Display(Name = "Edad")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int Edad { get; set; }


        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}",
        ApplyFormatInEditMode = true)]
        public DateTime FechaNacimiento { get; set; }

        [Display(Name = "Ubicacion")]
        [MaxLength(20, ErrorMessage = "No se permiten más de 20 dígitos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Ubicacion { get; set; }

        [Display(Name = "Correo")]
        [MaxLength(20, ErrorMessage = "No se permiten más de 20 dígitos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string correo { get; set; }

        [Display(Name = "Situacion")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Situacion { get; set; }

        public int FundacionId { get; set; } = 1;
        
        [JsonIgnore]
        public Fundacion Fundaciones { get; set; }

       

        [JsonIgnore]
       public ICollection<Conversacion> conversacions { get; set; }
       

    }
}
