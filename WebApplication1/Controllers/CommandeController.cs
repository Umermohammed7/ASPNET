using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class CommandeController : Controller
    {
        public IActionResult SupprimerCommande()
        {
            return View();
        }

        public IActionResult ValiderCommande()
        {
            return View();
        }

        public IActionResult ModifierCommande()
        {
            return View();
        }
    }
}
