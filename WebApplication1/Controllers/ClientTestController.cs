using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ClientTestController : Controller
    {
        public IActionResult ClientTest()
        {
            Client client = new Client();

            client.Name= "umer";
            client.Email = "user@gmail.com";

            ViewBag.Nom = client.Name;
            ViewBag.Email = client.Email;



            return View();
        }
        public IActionResult ClientTest1()
        {
            ViewData.Add("Nom","Nom user");
            ViewData.Add("Prenom","Prenomn user");

           

            

            return View();
        }
    }
}
