using Ecommerce_website.Data;
using Ecommerce_website.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce_website.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Get List of Product.

        public IActionResult Index()
        {
            return View(_context.products.ToList());
        }



        public IActionResult Create()
        {
            return View();
        }

        // Create Product

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);

        }



        public IActionResult Edit(int Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            
              var Product = _context.products.Find(Id);
                {
                    if(Product == null) 
                    {
                        return NotFound();
                    }
                }
                    
            
            return View(Product);
        }

        // Edit Product

        [HttpPost]

        public IActionResult Edit(int id, Product product)
        {
            if (id != product.ProductId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _context.Update(product);
                _context.SaveChanges();
            }
            if (!ProductExist(product.ProductId))
                return NotFound();
                return RedirectToAction("Index");
        }

        private bool ProductExist(int productId)
        {
            return _context.products.Any(p => p.ProductId == productId);    
        }

        public IActionResult Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = _context.products.FirstOrDefault(e => e.ProductId == id);
            if (product == null)

            {
                return NotFound();
            }

            return View(product);
        }

        // Delete Product

        [HttpPost]
        public IActionResult DeleteConfirmed(int ProductId)
        {
            var productid = _context.products.FirstOrDefault(p => p.ProductId == ProductId);
            if(productid != null)
            {
               _context.products.Remove(productid);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }


    }

}
