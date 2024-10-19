using BookApp.Data;
using BookApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using BookApp.Data;
using BookApp.Models;

namespace BookApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var Product = _context.Product.ToList();
            return View("~/Views/Home/Index.cshtml", Product);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult ProductDetail(int ProductId)
        {
            var product = _context.Product.FirstOrDefault(p => p.Id == ProductId);
            if (product == null)
            {
                return NotFound();
            }

            return View("~/Views/ProductDetails/ProductDetail.cshtml", product);

        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}

