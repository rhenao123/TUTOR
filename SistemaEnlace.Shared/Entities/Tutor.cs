using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEnlace.Shared.Entities
{
    public class Tutor : Persona
    {

        [Display(Name = "Experiencia")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        private int Experiencia { get; set; }

    }
}
