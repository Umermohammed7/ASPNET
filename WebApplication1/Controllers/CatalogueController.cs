using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class CatalogueController : Controller
    {
        public IActionResult Filtre()
        {
            return View();
        }

        public IActionResult Recherche()
        {
            return View();
        }

        public IActionResult AjouterCatalogue()
        {
            return View();
        }

        public IActionResult SupprimerCatalogue()
        {
            return View();
        }

        public IActionResult ModifierCatalogue()
        {
            return View();
        }
    }
}
