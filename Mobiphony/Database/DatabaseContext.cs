using Mobiphony.Models;
using Microsoft.EntityFrameworkCore;

namespace Mobiphony.Database
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
