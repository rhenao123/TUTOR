using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaEnlace.API.Data;
using SistemaEnlace.Shared.Entities;

namespace SistemaEnlace.API.Controllers
{
    [ApiController]
    [Route("/api/Formularios")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    public class FormularioControllers : ControllerBase

    {

        //


        private readonly DataContext _context;

        public FormularioControllers(DataContext context)
        {
            _context = context;
        }

        //Metodo get
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.formularios.ToListAsync());


        }

        // Método Get- por Id
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {



            var formularios = await _context.formularios.FirstOrDefaultAsync(x => x.Id == id);

            if (formularios == null)
            {


                return NotFound();

            }



            return Ok(formularios);


        }





        [HttpPost]
        public async Task<ActionResult> Post(Formulario formularios)
        {




            _context.Add(formularios);
            await _context.SaveChangesAsync();
            return Ok(formularios);



        }



        // Método actualizar
        [HttpPut]
        public async Task<ActionResult> Put(Formulario formularios)
        {

            _context.Update(formularios);
            await _context.SaveChangesAsync();
            return Ok(formularios);



        }


        //Médoro eliminar registro
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {



            var Filasafectadas = await _context.formularios

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

