using Microsoft.AspNetCore.Mvc;
using Mobiphony.Common;

namespace Mobiphony.Controllers.PhoneLogo
{
    public class PhoneLogoController : Controller
    {
        public IActionResult CardLogo()
        {
            return View();
        }
    }
}
