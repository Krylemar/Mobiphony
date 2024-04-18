using Mobiphony.Models;
using System.Drawing.Drawing2D;

namespace Mobiphony.Services
{
    public class PhoneRepository
    {
        private readonly DatabaseContext _context;

        public PhoneRepository(DatabaseContext context)
        {
            _context = context;
        }

        public void AddPhone(Phone phone)
        {
            _context.Phones.Add(phone);
            _context.SaveChanges();
        }

        public List<Brand> GetAllBrands()
        {
            return _context.Brands.ToList();
        }

        public List<CameraFeature> GetAllCameraFeatures() 
        {
            return _context.CameraFeatures.ToList();
        }

        public List<Feature> GetAllPhoneFeatures()
        {
			return _context.Features.ToList();
		}

        public List<DisplayMatrix> GetAllDisplayMatrices()
        {
			return _context.DisplayMatrices.ToList();
		}

        public Brand GetBrandById(int id) 
        {
            return _context.Brands.Find(id);
        }

        public DisplayMatrix GetDisplayMatrixById(int id) 
        {
            return _context.DisplayMatrices.Find(id);
        }

	}
}
