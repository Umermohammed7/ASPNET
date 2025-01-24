using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Select()
        {
            return View();
        }

        public ActionResult Proceed()
        {
            return View();
        }

        public ActionResult Cancel()
        {
            return View();
        }

    }

}
