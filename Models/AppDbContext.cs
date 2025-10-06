using Microsoft.EntityFrameworkCore;

namespace Clickbait_usuarios.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }    
    }
}
