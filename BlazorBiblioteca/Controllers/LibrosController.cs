using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlazorBiblioteca.Context;
using BlazorBiblioteca.Models;

namespace BlazorBiblioteca.Controllers
{
    // Controlador encargado de gestionar los libros.
    [Route("api/[controller]")]
    [ApiController]
    public class LibrosController : ControllerBase
    {
        private readonly LibroDBContext _context;

        // Constructor que recibe el contexto por inyección de dependencias.
        public LibrosController(LibroDBContext context)
        {
            _context = context;
        }

        // Obtiene todos los libros almacenados en la base de datos.
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Libro>>> GetLibros()
        {
            return await _context.Libros.ToListAsync();
        }

        // Agrega un nuevo libro a la base de datos.
        [HttpPost]
        public async Task<ActionResult<Libro>> PostLibro(Libro libro)
        {
            _context.Libros.Add(libro);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetLibros),
                new { id = libro.Id },
                libro);
        }
    }
}
