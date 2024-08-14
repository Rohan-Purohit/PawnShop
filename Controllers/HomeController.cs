using Microsoft.AspNetCore.Mvc;
using PawnShop.Models;
using System.Diagnostics;

namespace PawnShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly PawnShopeeContext _context;

        public HomeController(PawnShopeeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var categories = _context.Categories.ToList();
            var latestProducts = _context.Products
                                         .OrderByDescending(p => p.DateAdded)
                                         .Take(12) // 4 rows, assuming 3 products per row
                                         .ToList();

            var model = new HomeViewModel
            {
                Categories = categories,
                LatestProducts = latestProducts
            };

            return View(model);
        }

        public IActionResult AboutUs()
        {
            return View();
        }
    }
}
