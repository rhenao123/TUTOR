using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaEnlace.API.Data;
using SistemaEnlace.Shared.Entities;

namespace SistemaEnlace.API.Controllers
{
    [ApiController]
    [Route("/api/Tutor")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    public class TutorController : ControllerBase

    {




        private readonly DataContext _context;

        public TutorController(DataContext context)
        {
            _context = context;
        }

        //Metodo get
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Tutores.ToListAsync());


        }

        // Método Get- por Id
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {



            var tutor = await _context.Tutores.FirstOrDefaultAsync(x => x.id == id);

            if (tutor == null)
            {


                return NotFound();

            }



            return Ok(tutor);


        }





        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Post(Tutor tutor)
        {

            _context.Add(tutor);
            await _context.SaveChangesAsync();
            return Ok(tutor);



        }



        // Método actualizar
        [HttpPut]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Put(Tutor tutor)
        {

            _context.Update(tutor);
            await _context.SaveChangesAsync();
            return Ok(tutor);



        }


        //Médoro eliminar registro
        [HttpDelete("{id:int}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Delete(int id)
        {



            var Filasafectadas = await _context.Tutores

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

