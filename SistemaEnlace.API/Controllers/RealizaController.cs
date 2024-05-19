using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaEnlace.API.Data;
using SistemaEnlace.Shared.Entities;

namespace SistemaEnlace.API.Controllers
{
    [ApiController]
    [Route("/api/Realiza")]
    public class RealizaController : ControllerBase

    {




        private readonly DataContext _context;

        public RealizaController(DataContext context)
        {
            _context = context;
        }

        //Metodo get
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.realizas.ToListAsync());


        }

        // Método Get- por Id
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {



            var realiza = await _context.realizas.FirstOrDefaultAsync(x => x.Id == id);

            if (realiza == null)
            {


                return NotFound();

            }



            return Ok(realiza);


        }





        [HttpPost]
        public async Task<ActionResult> Post(Realiza realiza)
        {

            _context.Add(realiza);
            await _context.SaveChangesAsync();
            return Ok(realiza);



        }



        // Método actualizar
        [HttpPut]
        public async Task<ActionResult> Put(Realiza realiza)
        {

            _context.Update(realiza);
            await _context.SaveChangesAsync();
            return Ok(realiza);



        }


        //Médoro eliminar registro
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {



            var Filasafectadas = await _context.realizas

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


