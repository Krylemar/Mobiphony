
using AutoDjambazi.Database;
using Microsoft.EntityFrameworkCore;

namespace AutoDjambazi.Models
{
    /// <summary>Табличен клас за телефоните</summary>
    public class PhonesRepository : IPhoneRepository
    {

        //-------------------------
        //Constants:
        //-------------------------
        private readonly DatabaseContext _dbContext;

        //-------------------------
        //Members:
        //-------------------------

        //-------------------------
        //Properties:
        //-------------------------

        //-------------------------
        //Constructor/Destructor:
        //-------------------------
        public PhonesRepository(DatabaseContext _dbContext)
        {
            this._dbContext = _dbContext;
        }

        //-------------------------
        //Methods:
        //-------------------------

        //-------------------------
        //Overrides:
        //-------------------------

        public IEnumerable<Phones> SelectAllPhones
            => _dbContext.Phones.ToList();

        public Phones? GetPhoneByID(int id)
            => _dbContext.Phones.SingleOrDefault(row => row.Id == id);
    }
}
