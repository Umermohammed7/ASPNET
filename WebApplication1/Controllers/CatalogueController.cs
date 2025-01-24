using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class CatalogueController : Controller
    {
        public IActionResult List()
        {
            return View();
        }

        //public IActionResult Sort() {
    }
}
