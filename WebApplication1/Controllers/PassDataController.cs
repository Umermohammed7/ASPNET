using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;
using Microsoft.Identity.Client.TelemetryCore.TelemetryClient;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PassDataController : Controller
    {
        public IActionResult Data()
        {

            ViewBag.messagedata = "hello word ";
            return View();
        }

        public IActionResult Support()
        {
               
            
            return View();
        }

        public IActionResult TempDataSupport()
            {
            TempData["age"] = "Test data";
            var data = TempData["age"];
            ViewData["age"] = data;
            TempData.Keep();
               
           

            return View();
        }
        public IActionResult TempDataSupport2() 
        {

            ViewData["age"] = TempData["age"];


            return View();
        }

        public IActionResult Details()
        {
            var product = new Client
            {
                Id = 1,
                Name = "Laptop",
                Price = 999
            };
            ViewData["Product"] = product;
            return View();
            
        }

        public IActionResult InscriptionClient() 
        {
            var inscriptionclient = new Client
            {
                Id = 1,
                Name = "hassen",
                
                Address = "paris",
                Email = "user@gmail.com"
            };
            ViewData["inscri"] = inscriptionclient;

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

            var client = new Client
            {
                Name = "moi",
                Email = "email@example.com"
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
