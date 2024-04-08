using Microsoft.AspNetCore.Mvc;
using Mobiphony.Models;

namespace Mobiphony.Controllers.Phones
{
	public class PhonesController : Controller
	{
		//-------------------------
		//Constants:
		//-------------------------

		//-------------------------
		//Members:
		//-------------------------
		private IPhoneRepository _phoneRepository;

		//-------------------------
		//Properties:
		//-------------------------

		//-------------------------
		//Constructor/Destructor:
		//-------------------------
		public PhonesController(IPhoneRepository phoneRepository)
		{
			_phoneRepository = phoneRepository;
		}

		//-------------------------
		//Methods:
		//-------------------------
		public IActionResult Phones()
		{
			var phones = _phoneRepository.SelectAllPhones;

			return View(phones);
		}
		//-------------------------
		//Overrides:
		//-------------------------

	}
}
