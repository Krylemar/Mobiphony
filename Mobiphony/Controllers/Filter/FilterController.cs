using Microsoft.AspNetCore.Mvc;
using Mobiphony.Services;

namespace Mobiphony.Controllers.Filter
{
	public class FilterController : Controller
	{
		private readonly PhoneRepository _phoneRepository;

        public FilterController(PhoneRepository phoneRepository)
        {
			_phoneRepository = phoneRepository;
        }
        public IActionResult Filter()
		{
			ViewData["Brands"] = _phoneRepository.GetAllBrands();
			ViewData["CameraFeatures"] = _phoneRepository.GetAllCameraFeatures();
			ViewData["PhoneFeatures"] = _phoneRepository.GetAllPhoneFeatures();
			ViewData["DisplayMatrices"] = _phoneRepository.GetAllDisplayMatrices();
			return View();
		}
	}
}
