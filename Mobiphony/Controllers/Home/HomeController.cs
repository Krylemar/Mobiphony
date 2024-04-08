namespace Mobiphony.Controllers.Home
{
    #region
    using Microsoft.AspNetCore.Mvc;
    using Mobiphony.Common;
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
            return View();
        }

        //-------------------------
        //Overrides:
        //-------------------------

    }
}
