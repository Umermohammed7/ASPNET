using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PassdataController : Controller
    {
        public IActionResult Data()
        {
            TempData["user"] = "tempdata";
            var data = TempData["user"];
            ViewData["user"] = data;
            TempData.Keep();
            return View();

        }
        public ActionResult Data2()
        {
            ViewData["temp2"]= TempData["user"];
            return View();
        }



        public ActionResult ActTempData()
        {
            TempData["age"] = "Test data";
            // var data = TempData["age"];
            // ViewData["age"] = data;
            return View();
        }



        public ActionResult Details2()
        {
            var produit = new Produit
            {
                Id = 1,
                Name = "Laptop",
                Price = 500
            };

            var client = new Custommer
            {
                Nom = "moi",
                email = "email@example.com"
            };

            var viewModel = new ClientProduitViewModel
            {
                produits = produit,
                clients = client
            };

            return View(viewModel);
        }

    }

}
