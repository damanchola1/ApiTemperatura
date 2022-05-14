using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiTemperatura.Models;
using System;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiTemperatura.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemperaturasController : ControllerBase
    {
        private readonly AplicationDbContext context;

        public TemperaturasController(AplicationDbContext newcontext)
        {
            context = newcontext;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listaTemperaturas = await context.Temperaturas.ToListAsync();
                return Ok(listaTemperaturas);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }

        }

        // POST api/<TemperaturasController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Temperaturas temperatura)
        {
            try{

                context.Add(temperatura);
                await context.SaveChangesAsync();
                return Ok( new { message = "guardado"});
            }
            catch (Exception e )
            {
                return BadRequest(e);
            }

        }
    }
}
