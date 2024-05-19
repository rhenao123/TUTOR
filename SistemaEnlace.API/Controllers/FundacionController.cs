using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaEnlace.API.Data;
using SistemaEnlace.Shared.Entities;

namespace SistemaEnlace.API.Controllers
{
  

        [ApiController]
        [Route("/api/Fundacion")]
        public class FundacionController : ControllerBase

        {




            private readonly DataContext _context;

            public FundacionController(DataContext context)
            {
                _context = context;
            }

            //Metodo get
            [HttpGet]
            public async Task<ActionResult> Get()
            {
            return Ok(await _context.fundacions.ToListAsync());


        }

        // Método Get- por Id
        [HttpGet("{id:int}")]
            public async Task<ActionResult> Get(int id)
            {



                var fundacion = await _context.fundacions.FirstOrDefaultAsync(x => x.Id == id);

                if (fundacion == null)
                {


                    return NotFound();

                }



                return Ok(fundacion);


            }





            [HttpPost]
            public async Task<ActionResult> Post(Fundacion fundacion)
            {

                _context.Add(fundacion);
                await _context.SaveChangesAsync();
                return Ok(fundacion);



            }



            // Método actualizar
            [HttpPut]
            public async Task<ActionResult> Put(Fundacion fundacion)
            {

                _context.Update(fundacion);
                await _context.SaveChangesAsync();
                return Ok(fundacion);



            }


            //Médoro eliminar registro
            [HttpDelete("{id:int}")]
            public async Task<ActionResult> Delete(int id)
            {



                var Filasafectadas = await _context.fundacions

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

