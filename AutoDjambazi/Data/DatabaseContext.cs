using AutoDjambazi.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoDjambazi.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }

        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }
    }
}
