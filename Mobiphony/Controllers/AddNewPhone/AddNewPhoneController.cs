namespace Mobiphony.Controllers.AddNewPhone
{
	#region
	using Microsoft.AspNetCore.Mvc;
	using Mobiphony.Models;
	#endregion

	/// <summary></summary>
	public class AddNewPhoneController : Controller
	{
		//-------------------------
		//Constants:
		//-------------------------

		//-------------------------
		//Members:
		//-------------------------
		private readonly IPhoneRepository _phonesRepository;

		//-------------------------
		//Properties:
		//-------------------------

		//-------------------------
		//Constructor/Destructor:
		//-------------------------
		public AddNewPhoneController(IPhoneRepository phoneRepository)
		{
			this._phonesRepository = phoneRepository;
		}

		public IActionResult AddNewPhone()
		{
			return View();
		}

		//-------------------------
		//Methods:
		//-------------------------
		[HttpPost]
		public IActionResult AddNewPhone(Phones phone)
		{
			if (ModelState.IsValid)
			{
				_phonesRepository.InsertPhone(phone);
			}

			//TODO ADAM:
			//редиркт ей тука трябва да имаме + валидация горе

			return View();		
		}
		//-------------------------
		//Overrides:
		//-------------------------
	}
}

