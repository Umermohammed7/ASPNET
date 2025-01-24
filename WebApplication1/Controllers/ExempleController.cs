using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ExempleController : Controller
    {
        public IActionResult FirstExemple()
        {
            return View();
        }
    }
}
