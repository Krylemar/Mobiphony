using Mobiphony.Database;
using Microsoft.EntityFrameworkCore;

namespace Mobiphony.Models
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

        public void InsertPhone(Phones phone)
        {
			_dbContext.Add(phone);
			_dbContext.SaveChanges();
		}
	}
}
