using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class Authentification : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login ()
        {
            return View();
        }

        public IActionResult Inscription()
        {
            return View();
        }

       
    }
}
