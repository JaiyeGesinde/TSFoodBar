using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TSFoodBar.Data;
using TSFoodBar.Models;
using TSFoodBar.Models.ViewModels;

namespace TSFoodBar.Controllers
{
    [Authorize(Policy = "Adminpages")]

    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DashboardController(ApplicationDbContext db)
        {
            _db = db;
        }
        // GET: DashboardController
       /* public ActionResult Index()
        {
            return View();
        }*/

        // GET: DashboardController/Details/5
        public ActionResult Details(int id)
        {
            var starterList = _db?.Starters?.ToList();

            return View(starterList);
        }

        // GET: DashboardController/Create
        [HttpGet]
        public ActionResult Create(int? id)
        {
            //var starterList = _db?.Starters?.ToList();
           /* ViewData.Model = new Starters();
            ViewData.Model = new Mains();
            ViewData.Model = new Desserts();
            ViewData.Model = new Drinks();*/
            return View();
        }

        // POST: DashboardController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Starters starterModel)
        {
            try
            {
                /*return RedirectToAction(nameof(Index));*/
                if (ModelState.IsValid)
                {
                    _db?.Starters?.Add(starterModel);

                    _db?.SaveChanges();

                    return View(starterModel);
                }

                return View(starterModel);
            }
            catch
            {
                return View();
            }
        }

        // GET: DashboardController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DashboardController/Edit/5
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

        // GET: DashboardController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id)
        {

            var starterId = int.Parse(id);

            var item = _db?.Starters?.Find(starterId);

            _db?.Starters?.Remove(item!);

            _db?.SaveChanges();

            var updatedList = _db?.Starters?.ToList();

            return View("Details", updatedList);
        }

        //// POST: DashboardController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
