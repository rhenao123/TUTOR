using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEnlace.Shared.Entities
{
    public class JovenVulnerable:Persona
    {


        [Display(Name = "Situacion")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        private string Situacion { get; set; }





    }
}
