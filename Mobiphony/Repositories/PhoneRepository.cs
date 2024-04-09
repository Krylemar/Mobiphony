using Mobiphony.Models;

namespace Mobiphony.Services
{
    public class PhoneRepository
    {
        private readonly DatabaseContext _context;

        public PhoneRepository(DatabaseContext context)
        {
            _context = context;
        }

        public void AddPhone(Phone phone, int[] selectedFeatureIds)
        {
            if (selectedFeatureIds != null)
            {
                foreach (var featureId in selectedFeatureIds)
                {
                    phone.Features.Add(new Feature { Id = featureId });
                }
            }
            _context.Phones.Add(phone);
            _context.SaveChanges();
        }
    }
}
