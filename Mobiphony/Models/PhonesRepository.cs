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
		private readonly DatabaseContext _databaseContext;
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
            this._databaseContext = _dbContext;
        }

        //-------------------------
        //Methods:
        //-------------------------

        //-------------------------
        //Overrides:
        //-------------------------

        public IEnumerable<Phones> SelectAllPhones
            => _databaseContext.Phones.ToList();

        public Phones? GetPhoneByID(int id)
            => _databaseContext.Phones.SingleOrDefault(row => row.Id == id);

        public void InsertPhone(Phones phone)
        {
			_databaseContext.Add(phone);
			_databaseContext.SaveChanges();
		}
	}
}
