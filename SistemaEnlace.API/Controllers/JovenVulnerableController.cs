using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaEnlace.API.Data;
using SistemaEnlace.Shared.Entities;


namespace SistemaEnlace.API.Controllers
{


    [ApiController]
    [Route("/api/JovenVul")]
    public class JovenVulnerableController : ControllerBase

    {




        private readonly DataContext _context;

        public JovenVulnerableController(DataContext context)
        {
            _context = context;
        }

        //Metodo get
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.JovenesVulnerables.ToListAsync());


        }

        // Método Get- por Id
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {



            var jovenVulnerable = await _context.JovenesVulnerables.FirstOrDefaultAsync(x => x.id == id);

            if (jovenVulnerable == null)
            {


                return NotFound();

            }



            return Ok(jovenVulnerable);


        }





        [HttpPost]
        public async Task<ActionResult> Post(JovenVulnerable jovenVulnerable)
        {
          if (jovenVulnerable.FundacionId==0)
            {
                jovenVulnerable.FundacionId=1;
            }
            _context.Add(jovenVulnerable);
            await _context.SaveChangesAsync();
            return Ok(jovenVulnerable);



        }



        // Método actualizar
        [HttpPut]
        public async Task<ActionResult> Put(JovenVulnerable jovenVulnerable)
        {

            _context.Update(jovenVulnerable);
            await _context.SaveChangesAsync();
            return Ok(jovenVulnerable);



        }


        //Médoro eliminar registro
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {



            var Filasafectadas = await _context.JovenesVulnerables

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
