using Microsoft.AspNetCore.Mvc;
using Mobiphony.Common;

namespace Mobiphony.Controllers.Cards
{
	public class PhoneLogoController : Controller
	{
		public IActionResult CardLogo()
		{
			return View();
		}
	}
}
