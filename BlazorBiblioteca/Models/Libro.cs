using System.ComponentModel.DataAnnotations;

namespace BlazorBiblioteca.Models
{
    // Representa un libro de la biblioteca
    public class Libro
    {
        // Clave primaria de la tabla
        public int Id { get; set; }

        // Nombre del libro
        [Required(ErrorMessage = "Debe ingresar el nombre del libro.")]
        public string NombreLibro { get; set; } = string.Empty;

        // Autor del libro
        [Required(ErrorMessage = "Debe ingresar el nombre del autor.")]
        public string Autor { get; set; } = string.Empty;

        // Cantidad de páginas
        [Required(ErrorMessage = "Debe ingresar la cantidad de páginas.")]
        [Range(2, int.MaxValue,
            ErrorMessage = "La cantidad de páginas debe ser mayor que 1.")]
        public int? NumPaginas { get; set; }

        // Fecha de publicación
        public DateTime FechaPublicacion { get; set; }
    }
}