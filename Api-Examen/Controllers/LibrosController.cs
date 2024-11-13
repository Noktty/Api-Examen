using Api_Examen.Data;
using Api_Examen.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api_Examen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibrosController : ControllerBase
    {
        private readonly LibroDBContext _context;

        public LibrosController(LibroDBContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<IEnumerable<Libro>> Get()
        {
            return await _context.Libros.ToListAsync();
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Libro>> GetById (int Id)
        {
            var libro = await _context.Libros.FindAsync(Id);

            if (libro == null)
            {
                return NotFound();
            }
            
            return Ok(libro);
        }

        [HttpPost]
        public async Task<ActionResult<Libro>> Post()
        {
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Put()
        {
            return BadRequest();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete()
        {
            return Ok();
        }

    }
}
