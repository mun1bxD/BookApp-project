using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookApp.Data;
using BookApp.Models;

namespace BookApp.Controllers
{
    [Authorize(Roles = BookApp.Models.User.Admin)]
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = BookApp.Models.User.Admin)]
        public IActionResult ContentManagement()
        {
            var Product = _context.Product.ToList();
            return View("~/Views/ProductDetails/ContentManagement.cshtml", Product);
        }


        [Authorize(Roles = BookApp.Models.User.Admin)]
        public IActionResult DeleteItem(int productId)
        {
            var product = _context.Product.FirstOrDefault(p => p.Id == productId);
            if (product == null)
            {
                return NotFound();
            }
            return View("~/Views/ProductDetails/DeleteItem.cshtml", product);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("DeleteItem")]
        [Authorize(Roles = BookApp.Models.User.Admin)]
        public async Task<IActionResult> DeletePost(int id)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");

        }

        [Authorize(Roles = BookApp.Models.User.Admin)]
        public IActionResult AddItem()
        {
            return View("~/Views/ProductDetails/AddItem.cshtml");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = BookApp.Models.User.Admin)]
        public async Task<IActionResult> AddItem(Product product, IFormFile ImageFile)
        {
            if (!ModelState.IsValid)
            {
                return View("~/Views/ProductDetails/AddItem.cshtml", product);
            }
            if (ImageFile != null && ImageFile.Length > 0)
            {
                var filename = Path.GetFileName(ImageFile.FileName);
                var filepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images", filename);

                using (var stream = new FileStream(filepath, FileMode.Create))
                {
                    await ImageFile.CopyToAsync(stream);
                }
                product.Image = $"Images/{filename}";
            }
            _context.Product.Add(product);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");

        }


        [Authorize(Roles = BookApp.Models.User.Admin)]
        public IActionResult EditItem(int productid)
        {
            var product = _context.Product.FirstOrDefault(item => item.Id == productid);
            if (product == null)
            {
                return NotFound();
            }
            return View("~/Views/ProductDetails/EditItem.cshtml", product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = BookApp.Models.User.Admin)]
        public async Task<IActionResult> EditItem(ProductEdit model, IFormFile imageFile)
        {

            var product = _context.Product.FirstOrDefault(p => p.Id == model.Id);

            if (product == null)
            {
                return NotFound();
            }
            product.Title = model.Title;
            product.ISBN = model.ISBN;
            product.Price = model.Price;
            product.Author = model.Author;
            product.Description = model.Description;
            if (imageFile != null && imageFile.Length > 0)
            {
                var filename = Path.GetFileName(imageFile.FileName);
                var filepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images", filename);

                using (var stream = new FileStream(filepath, FileMode.Create))
                {
                    await imageFile.CopyToAsync(stream);
                }
                product.Image = $"Images/{filename}";
            }

            _context.Product.Update(product);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        public async Task<byte[]> ConvertImageToFile(IFormFile imageFile)
        {
            using (var memoryStream = new MemoryStream())
            {
                await imageFile.CopyToAsync(memoryStream);
                return memoryStream.ToArray();
            }
        }
    }
}
