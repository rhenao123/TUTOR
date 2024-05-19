using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaEnlace.API.Data;
using SistemaEnlace.Shared.Entities;

namespace SistemaEnlace.API.Controllers
{
    [ApiController]
    [Route("/api/Supervisa")]
    public class SupervisaController : ControllerBase

    {




        private readonly DataContext _context;

        public SupervisaController(DataContext context)
        {
            _context = context;
        }

        //Metodo get
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.supervisas.ToListAsync());


        }

        // Método Get- por Id
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {



            var supervisa = await _context.supervisas.FirstOrDefaultAsync(x => x.Id == id);

            if (supervisa == null)
            {


                return NotFound();

            }



            return Ok(supervisa);


        }





        [HttpPost]
        public async Task<ActionResult> Post(Supervisa supervisa)
        {

            _context.Add(supervisa);
            await _context.SaveChangesAsync();
            return Ok(supervisa);



        }



        // Método actualizar
        [HttpPut]
        public async Task<ActionResult> Put(Supervisa supervisa)
        {

            _context.Update(supervisa);
            await _context.SaveChangesAsync();
            return Ok(supervisa);



        }


        //Médoro eliminar registro
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {



            var Filasafectadas = await _context.supervisas

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

