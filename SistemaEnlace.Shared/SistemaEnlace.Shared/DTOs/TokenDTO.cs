using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaEnlace.Shared.Entities;

namespace SistemaEnlace.Shared.DTOs
{
    public class TokenDTO
    {
        public string Token { get; set; } = null!;

        public DateTime Expiration { get; set; }

    }
}
