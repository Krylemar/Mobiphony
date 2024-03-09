using System.IO.Pipelines;

namespace AutoDjambazi.Models
{
    public interface IPhoneRepository
    {
        IEnumerable<Phones> SelectAllPhones { get; }
        Phones? GetPhoneByID(int id);
    }
}
