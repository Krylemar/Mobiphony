using Microsoft.AspNetCore.Mvc;
using Mobiphony.Models;
using Mobiphony.Services;

namespace Mobiphony.Controllers.Phones
{
    public class PhonesController : Controller
    {
		private readonly PhoneRepository _phoneRepository;

        public PhonesController(PhoneRepository phoneRepository)
        {
			_phoneRepository = phoneRepository;
		}
        public IActionResult Phone()
        {
            return View("Phone");
        }

		public IActionResult Phones()
		{
			return View("Phones");
		}

		[HttpGet]
		public IActionResult AddPhone()
		{
			ViewData["Brands"] = _phoneRepository.GetAllBrands();
			ViewData["CameraFeatures"] = _phoneRepository.GetAllCameraFeatures();
			ViewData["PhoneFeatures"] = _phoneRepository.GetAllPhoneFeatures();
			ViewData["DisplayMatrices"] = _phoneRepository.GetAllDisplayMatrices();
			return View();
		}

		[HttpPost]
		public IActionResult AddPhone(Phone phone, CameraFeature[] selectedCameraFeatures, Feature[] selectedPhoneFeatures)
		{
			ViewData["Brands"] = _phoneRepository.GetAllBrands();
			ViewData["CameraFeatures"] = _phoneRepository.GetAllCameraFeatures();
			ViewData["PhoneFeatures"] = _phoneRepository.GetAllPhoneFeatures();
			ViewData["DisplayMatrices"] = _phoneRepository.GetAllDisplayMatrices();
			if (ModelState.IsValid)
			{
				Phone newPhone = new Phone
				{
					Brand = phone.Brand,
					Model = phone.Model,
					Length = phone.Length,
					Width = phone.Width,
					Thickness = phone.Thickness,
					Sim = phone.Sim,
					Iprating = phone.Iprating,
					DisplaySize = phone.DisplaySize,
					Matrix = phone.Matrix,
					RefreshRate = phone.RefreshRate,
					Brightness = phone.Brightness,
					Resolution = phone.Resolution,
					ScreenProtection = phone.ScreenProtection,
					Chipset = phone.Chipset,
					Cpu = phone.Cpu,
					Gpu = phone.Gpu,
					Os = phone.Os,
					WiFiSpeed = phone.WiFiSpeed,
					BluetoothVersion = phone.BluetoothVersion,
					Price = phone.Price,
					PurchaseLink = phone.PurchaseLink,
					Ram = phone.Ram,
					InternalStorage = phone.InternalStorage,
					ExpStorageLimit = phone.ExpStorageLimit,
					Usbtype = phone.Usbtype,
					FingerPrint = phone.FingerPrint,
					FaceRec = phone.FaceRec,
					BatCapacity = phone.BatCapacity,
					BatChargingWattage = phone.BatChargingWattage,
					MainCamPhoto = phone.MainCamPhoto,
					MainCamVideo = phone.MainCamVideo
				};
				newPhone.Features = selectedPhoneFeatures;
				newPhone.CameraFeatures = selectedCameraFeatures;
				newPhone.BrandNavigation = _phoneRepository.GetBrandById(phone.Brand);
				newPhone.MatrixNavigation = _phoneRepository.GetDisplayMatrixById(phone.Matrix);
				_phoneRepository.AddPhone(newPhone);

				return RedirectToAction(nameof(Index));
			}

			return View(phone);
		}
	}
}
