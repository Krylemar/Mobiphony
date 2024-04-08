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
		public IActionResult AddNewPhone()
		{
			return View();
		}

		[HttpPost]
		public IActionResult AddNewPhone(Phone phone)
		{
			_phoneRepository.AddPhone(phone);
			return View();		
		}
	}
}

