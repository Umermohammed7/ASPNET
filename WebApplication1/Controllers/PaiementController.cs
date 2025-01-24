using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PaiementController : Controller
    {
        public IActionResult DetailPaiement() //Montant total
        {
            Paiement paiement = new Paiement();
            paiement.Montant_total = 250;
            ViewBag.Montant_total = paiement.Montant_total;
            return View();
        }

        public IActionResult Detail() //Détail
        {
            ViewData.Add("detail", "250$ de café");
            return View();

        }
    }
}
