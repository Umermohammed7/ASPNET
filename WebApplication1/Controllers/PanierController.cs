using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class PanierController : Controller
    {
        public IActionResult AjouterPanier()
        {
            return View();
        }
        public IActionResult ValiderPanier()
        {
            return View();
        }
        public IActionResult ModifierQuantite()
        {
            return View();
        }
        public IActionResult SupprimerPanier()
        {
            return View();
        }
    }
}
