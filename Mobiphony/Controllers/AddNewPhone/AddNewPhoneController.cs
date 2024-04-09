namespace Mobiphony.Controllers.AddNewPhone
{
	#region
	using Microsoft.AspNetCore.Mvc;
	using Mobiphony.Models;
    using Mobiphony.Services;
    #endregion

    /// <summary></summary>
    public class AddNewPhoneController : Controller
	{
		private readonly PhoneRepository _phoneRepository;
		public AddNewPhoneController(PhoneRepository phoneRepository)
		{
			_phoneRepository = phoneRepository;
		}

        [HttpGet]
        public IActionResult AddNewPhone(Phone phone)
        {
            return View(phone);
        }

        [HttpPost]	
		public IActionResult AddNewPhone(Phone phone, int[] selectedFeatureIds)
		{
            if (ModelState.IsValid)
            {
                _phoneRepository.AddPhone(phone, selectedFeatureIds);
                // TODO: Add a success message and meaningful redirection
                return RedirectToAction(nameof(Index));
            }

            return View(phone);
        }
	}
}

