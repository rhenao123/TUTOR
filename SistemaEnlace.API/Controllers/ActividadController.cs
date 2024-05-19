﻿using Microsoft.AspNetCore.Mvc;
using SistemaEnlace.API.Data;

using Microsoft.EntityFrameworkCore;
using SistemaEnlace.Shared.Entities;



namespace SistemaEnlace.API.Controllers
{
    [ApiController]
    [Route("/api/Actividades")]
    public class ActividadController : ControllerBase

    {


      
      
            private readonly DataContext _context;

            public ActividadController(DataContext context)
            {
                _context = context;
            }

            //Metodo get
            [HttpGet]
            public async Task<ActionResult> Get()
            {
                return Ok(await _context.actividads.ToListAsync());


            }

            // Método Get- por Id
            [HttpGet("{id:int}")]
            public async Task<ActionResult> Get(int id)
            {



                var actividad = await _context.actividads.FirstOrDefaultAsync(x => x.id == id);

                if (actividad == null)
                {


                    return NotFound();

                }



                return Ok(actividad);


            }





            [HttpPost]
            public async Task<ActionResult> Post(Actividad actividad)
            {

                _context.Add(actividad);
                await _context.SaveChangesAsync();
                return Ok(actividad);



            }



            // Método actualizar
            [HttpPut]
            public async Task<ActionResult> Put(Actividad actividad)
            {

                _context.Update(actividad);
                await _context.SaveChangesAsync();
                return Ok(actividad);



            }


            //Médoro eliminar registro
            [HttpDelete("{id:int}")]
            public async Task<ActionResult> Delete(int id)
            {



                var Filasafectadas = await _context.actividads

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


