using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SampleProject_API.Controllers
{
    public class TMLController : Controller
    {
        // GET: TMLController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TMLController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TMLController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TMLController/Create
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

        // GET: TMLController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TMLController/Edit/5
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

        // GET: TMLController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TMLController/Delete/5
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
