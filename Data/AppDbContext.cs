using Microsoft.EntityFrameworkCore;
using DiarioVideojuegos.Models;

namespace DiarioVideojuegos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario>? Usuarios { get; set; }
        public DbSet<Vivencia>? Vivencias { get; set; }
    }
}