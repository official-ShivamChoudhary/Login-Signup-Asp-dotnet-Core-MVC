using Ecommerce_website.Data;
using Ecommerce_website.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce_website.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _context;
        public LoginController(ApplicationDbContext context)
        {
            _context = context; 
            
        }
        public IActionResult Login()
        {
            return View();
          
        }


        [HttpPost]
        public IActionResult Login(string Email, string Password)
        {
            var product = _context.registrartions.FirstOrDefault(u => u.Email == Email && u.Password == Password);

           if(product != null) 
            
            {
               return RedirectToAction("Index", "Product");
            }

            ModelState.AddModelError("", "Invalid Login credentials");
            return View("Login");
        }

        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signup(Registrartion registration)
        {
            if(ModelState.IsValid) 
            
            {
               if(_context.registrartions.Any(u => u.Email == registration.Email)) 
                
                {

                    return View(registration);
                }    
               _context.registrartions.Add(registration);   
                _context.SaveChanges();
                return RedirectToAction("Login");   
            }
            return View(registration);
        }

    }
}
