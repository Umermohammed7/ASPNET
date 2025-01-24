using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class DeliveryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
