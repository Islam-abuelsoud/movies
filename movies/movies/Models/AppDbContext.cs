using Microsoft.EntityFrameworkCore;

namespace Moves_List.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Move> Moves { get; set; }
    }
}
