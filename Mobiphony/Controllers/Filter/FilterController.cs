using Microsoft.AspNetCore.Mvc;
using Mobiphony.Models;

namespace Mobiphony.Controllers.Filter
{
	public class FilterController : Controller
	{
		private readonly DatabaseContext _context;

		public FilterController(DatabaseContext context)
        {
			_context = context;
        }
        public IActionResult Filter()
		{
			ViewData["Brands"] = _context.Brands.ToList();
			ViewData["CameraFeatures"] = _context.CameraFeatures.ToList();
			ViewData["PhoneFeatures"] = _context.Features.ToList();
			ViewData["DisplayMatrices"] = _context.DisplayMatrices.ToList();
			return View();
		}
	}
}
