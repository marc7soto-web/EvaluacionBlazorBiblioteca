using Microsoft.EntityFrameworkCore;
using BlazorBiblioteca.Models;

namespace BlazorBiblioteca.Context
{
    // Contexto de datos que permite a Entity Framework
    // conectarse con la base de datos BibliotecaDB.
    public class LibroDBContext : DbContext
    {
        // Constructor que recibe las opciones de configuración.
        public LibroDBContext(DbContextOptions<LibroDBContext> options)
            : base(options)
        {
        }

        // Representa la tabla Libros de la base de datos.
        public DbSet<Libro> Libros { get; set; }
    }
}