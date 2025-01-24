using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class AuthentificationController : Controller
    {
        public IActionResult Inscription()
        {
            return View();
        }
        public IActionResult Login() { 
            
            return View();
        }

        public IActionResult Logout() 
        {
            return View();
        }

    }
}
