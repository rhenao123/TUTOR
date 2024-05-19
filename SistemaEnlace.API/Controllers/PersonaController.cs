using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaEnlace.API.Data;
using SistemaEnlace.Shared.Entities;

namespace SistemaEnlace.API.Controllers
{


    [ApiController]
    [Route("/api/Personas")]
    public class personaController : ControllerBase

    {




        private readonly DataContext _context;

        public personaController(DataContext context)
        {
            _context = context;
        }

        //Metodo get
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.personas.ToListAsync());


        }

        // Método Get- por Id
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {



            var personas = await _context.personas.FirstOrDefaultAsync(x => x.id == id);

            if (personas == null)
            {


                return NotFound();

            }



            return Ok(personas);


        }





        [HttpPost]
        public async Task<ActionResult> Post(Persona persona)
        {

            _context.Add(persona);
            await _context.SaveChangesAsync();
            return Ok(persona);



        }



        // Método actualizar
        [HttpPut]
        public async Task<ActionResult> Put(Persona persona)
        {

            _context.Update(persona);
            await _context.SaveChangesAsync();
            return Ok(persona);



        }


        //Médoro eliminar registro
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {



            var Filasafectadas = await _context.personas

                .Where(x => x.id == id)
                .ExecuteDeleteAsync();

            if (Filasafectadas == 0)
            {


                return NotFound();

            }


            return NoContent();

        }
    }
}
