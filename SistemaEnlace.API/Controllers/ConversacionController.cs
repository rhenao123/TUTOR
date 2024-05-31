using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaEnlace.API.Data;
using SistemaEnlace.Shared.Entities;

namespace SistemaEnlace.API.Controllers
{

    [ApiController]
    [Route("/api/Conversaciones")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    public class ConversacionController : ControllerBase

    {




        private readonly DataContext _context;

        public ConversacionController(DataContext context)
        {
            _context = context;
        }

        //Metodo get
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.conversacions.ToListAsync());



        }

        // Método Get- por Id
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {



            var conversacion = await _context.conversacions.FirstOrDefaultAsync(x => x.Id == id);

            if (conversacion == null)
            {


                return NotFound();

            }



            return Ok(conversacion);


        }





        [HttpPost]
        public async Task<ActionResult> Post(Conversacion conversacion)
        {

            _context.Add(conversacion);
            await _context.SaveChangesAsync();
            return Ok(conversacion);



        }



        // Método actualizar
        [HttpPut]
        public async Task<ActionResult> Put(Conversacion conversacion)
        {

            _context.Update(conversacion);
            await _context.SaveChangesAsync();
            return Ok(conversacion);



        }


        //Médoro eliminar registro
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {



            var Filasafectadas = await _context.conversacions

                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();

            if (Filasafectadas == 0)
            {


                return NotFound();

            }


            return NoContent();

        }
    }
}


