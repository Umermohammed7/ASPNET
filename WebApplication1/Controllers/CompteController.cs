using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class CompteController : Controller
    {
        
        public IActionResult SupprimerClient()
        {
            return View();
        }
        public IActionResult ModifierClient()
        {
            return View();
        }


    }
}
