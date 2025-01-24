

using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PassDataController : Controller
    {
     
        public IActionResult TempDataExemple()
        {
            TempData["age"] = "Test Data";
            var data = TempData["age"];
            ViewData["user"] = data;
            TempData.Keep();
            return View();
        }

        public IActionResult KeepDataExemple()
        {
            ViewData["temp2"] = TempData["user"];
            return View();
        }



        public ActionResult Details()
        {
            var paiement = new Paiement
            {
                id = 1,
                detail = "250 euros de café",
                Montant_total = 250
            };

            ViewData["Paiement"] = paiement;
            return View();
        }




            public ActionResult Details2()
        {
            var paiement = new Paiement
            {
                id = 2,
                detail = "3500 euros de mouchoirs",
                Montant_total = 3500
            };

            var client = new ClientExemple
            {
                Id = 1,
                Name = "James"

            };

            var viewModel = new ClientPaiement
            {

                paiements = paiement,
                clients = client
            };


            return View(viewModel);

        }

    }
}
