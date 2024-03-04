using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoDjambazi.Controllers
{
    public class Extra : Controller
    {
        // GET: Extra
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AboutUs()
        {
            return View();
        }

        // GET: Extra/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Extra/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Extra/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Extra/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Extra/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Extra/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Extra/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
