namespace Mobiphony.Models
{
	#region
	#endregion
	public interface IPhoneRepository
    {
        IEnumerable<Phones> SelectAllPhones { get; }
        Phones? GetPhoneByID(int id);
        void InsertPhone(Phones phone);
    }
}
