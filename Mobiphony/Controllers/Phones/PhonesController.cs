using Microsoft.AspNetCore.Mvc;

namespace Mobiphony.Controllers.Phones
{
	public class PhoneController : Controller
	{
		public IActionResult Phones()
		{
			return View();
		}
	}
}
