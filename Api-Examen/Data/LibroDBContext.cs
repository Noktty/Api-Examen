using Microsoft.EntityFrameworkCore;

namespace Api_Examen.Data
{
    public class LibroDBContext : DbContext
    {
        public LibroDBContext(DbContextOptions<LibroDBContext> options)
            : base(options)
        {

        }

        public DbSet<Models.Libro> Libros { get; set; } 
    }
}
