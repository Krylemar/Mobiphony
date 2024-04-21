namespace Mobiphony.Controllers.Home
{
    #region
    using Microsoft.AspNetCore.Mvc;
    using Mobiphony.Common;
    #endregion

    /// <summary>Контролер обслужващ Index.cshtml</summary>
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
		public IActionResult AboutUs()
		{
			return View("AboutUs");
		}

	}
}
