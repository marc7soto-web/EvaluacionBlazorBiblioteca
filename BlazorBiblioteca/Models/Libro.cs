using System.ComponentModel.DataAnnotations;

namespace BlazorBiblioteca.Models
{
    // Representa un libro de la biblioteca
    public class Libro
    {
        // Clave primaria de la tabla
        public int Id { get; set; }

        // Nombre del libro
        [Required]
        public string NombreLibro { get; set; } = string.Empty;

        // Autor del libro
        [Required]
        public string Autor { get; set; } = string.Empty;

        // Cantidad de páginas
        public int NumPaginas { get; set; }

        // Fecha de publicación
        public DateTime FechaPublicacion { get; set; }
    }
}