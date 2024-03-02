namespace AutoDjambazi.Controllers
{
	#region
	using Microsoft.AspNetCore.Mvc;
	using AutoDjambazi.Common;
	#endregion

	/// <summary>Контролер обслужващ Index.cshtml</summary>
	public class HomeController : Controller
    {
        //-------------------------
        //Constants:
        //-------------------------

        //-------------------------
        //Members:
        //-------------------------

        //-------------------------
        //Properties:
        //-------------------------

        //-------------------------
        //Constructor/Destructor:
        //-------------------------

        //-------------------------
        //Methods:
        //-------------------------
        public IActionResult Index()
        {
            ViewBag.Title = Messages.MSG_WEBISTE_TITLE;
            return View();
        }

        //-------------------------
        //Overrides:
        //-------------------------

    }
}
