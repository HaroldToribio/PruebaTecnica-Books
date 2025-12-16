namespace Libros_Web.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty; // Esto es para evitar valores nulos
        public string Autor { get; set; } = string.Empty;
        public string Genero { get; set; } = string.Empty;
        public int Fecha_Publicacion { get; set; }
    }
}
