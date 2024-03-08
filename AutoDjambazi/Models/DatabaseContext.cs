using Microsoft.EntityFrameworkCore;

namespace AutoDjambazi.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }

        public DatabaseContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
