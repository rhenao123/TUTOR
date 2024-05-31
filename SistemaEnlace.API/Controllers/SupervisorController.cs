using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaEnlace.API.Data;
using SistemaEnlace.Shared.Entities;

namespace SistemaEnlace.API.Controllers
{
    [ApiController]
    [Route("/api/Supervisor")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    public class SupervisorController : ControllerBase

    {




        private readonly DataContext _context;

        public SupervisorController(DataContext context)
        {
            _context = context;
        }

        //Metodo get
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.supervisors.ToListAsync());


        }

        // Método Get- por Id
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {



            var supervisor = await _context.supervisors.FirstOrDefaultAsync(x => x.id == id);

            if (supervisor == null)
            {


                return NotFound();

            }



            return Ok(supervisor);


        }





        [HttpPost]
        public async Task<ActionResult> Post(Supervisor supervisor)
        {

            _context.Add(supervisor);
            await _context.SaveChangesAsync();
            return Ok(supervisor);



        }



        // Método actualizar
        [HttpPut]
        public async Task<ActionResult> Put(Supervisor supervisor)
        {

            _context.Update(supervisor);
            await _context.SaveChangesAsync();
            return Ok(supervisor);



        }


        //Médoro eliminar registro
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {



            var Filasafectadas = await _context.supervisors

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

