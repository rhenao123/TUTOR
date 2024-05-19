using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SistemaEnlace.Shared.Entities
{
    public class Fundacion
    {
        public int Id { get; set; }


        [Display(Name = "Nombre")]
        [MaxLength(20, ErrorMessage = "No se permiten más de 20 dígitos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Name { get; set; }

        [Display(Name = "Descripcion")]
        [MaxLength(20, ErrorMessage = "No se permiten más de 20 dígitos")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Description { get; set; }


        [JsonIgnore]

        public Persona Persona { get; set; }

        public int IdPersona { get; set; }  



    }
}
