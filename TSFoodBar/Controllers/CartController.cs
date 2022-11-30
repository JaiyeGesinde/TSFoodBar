using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TSFoodBar.Data;
using TSFoodBar.Models;

namespace TSFoodBar.Controllers
{
    public class CartController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CartController(ApplicationDbContext conext)
        {
            _context = conext;
        }
    

        // GET: CartController
        public ActionResult Index(int id)
        {
            if (id == 0 || id == null)
            {
                return NotFound();
            }
            /* var starterProduct = _context.Starters.Find(id);
             var mainProduct = _context.Mains.Find(id);
             if ( mainProduct !=null)
             {
                 return View(mainProduct); 

                     };
             if (starterProduct != null)
             {
                 return View(starterProduct);
             }*/
            var starterProduct = _context.Starters.Find(id);
            var mainProduct = _context.Mains.Find(id);
            var dessertProduct = _context.Desserts.Find(id);
            var drinkProduct = _context.Drinks.Find(id);
            if (starterProduct == null)
            {
                return NotFound();
            }
            return View(starterProduct);

            /* var obj = new { Avocado, Brandy };
            re
             return View(Avocado);*/
        }

        // GET: CartController/Details/5
        public ActionResult Details(int? id)
        {
            return View();
        }

        // GET: CartController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CartController/Create
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

        // GET: CartController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CartController/Edit/5
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

        // GET: CartController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CartController/Delete/5
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
