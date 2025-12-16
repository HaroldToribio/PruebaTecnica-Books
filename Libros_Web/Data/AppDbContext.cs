using Microsoft.EntityFrameworkCore;
using Libros_Web.Models;

namespace Libros_Web.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Book> Books { get; set; }

    }
}
