using AutoDjambazi.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoDjambazi.Database
{
    /// <summary>Контекс на базата данни</summary>
    public class DatabaseContext : DbContext
    {
        //-------------------------
        //Constants:
        //-------------------------

        //-------------------------
        //Members:
        //-------------------------

        //-------------------------
        //Properties:
        //-------------------------
        public DbSet<Phones> Phones { get; set; }

        //-------------------------
        //Constructor/Destructor:
        //-------------------------
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

        //-------------------------
        //Methods:
        //-------------------------

        //-------------------------
        //Overrides:
        //-------------------------
    }
}
