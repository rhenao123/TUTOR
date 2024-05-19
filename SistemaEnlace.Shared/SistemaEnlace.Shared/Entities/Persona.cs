using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SistemaEnlace.Shared.Entities
{
    public class Persona
    {


        private int id { get; set; }




        [Display(Name = "Nombre")]
        [MaxLength(20, ErrorMessage = "No se permiten más de 20 dígitos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        private string Nombre { get; set; }


        [Display(Name = "Apellido")]
        [MaxLength(20, ErrorMessage = "No se permiten más de 20 dígitos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        private string Apellidos { get; set; }

        [Display(Name = "Edad")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        private int Edad { get; set; }


        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}",
        ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        private DateTime FechaNacimiento { get; set; }

        [Display(Name = "Ubicacion")]
        [MaxLength(20, ErrorMessage = "No se permiten más de 20 dígitos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        private string Ubicacion { get; set; }

        [Display(Name = "Correo")]
        [MaxLength(20, ErrorMessage = "No se permiten más de 20 dígitos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        private string correo { get; set; }


        [JsonIgnore]
        public ICollection<Realiza> Realizas { get; set; }

    }
}
