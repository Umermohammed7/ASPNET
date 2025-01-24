using Microsoft.AspNetCore.Mvc;


namespace WebApplication1.Controllers
{
    public class RedirectController : Controller
    {
        // Action de redirection vers une autre action dans le même contrôleur
        public IActionResult RedirectToAnotherAction()
        {
            // Redirige vers l'action "TargetAction"
            return RedirectToAction("TargetAction");
        }

        // Action de redirection vers une autre action dans un autre contrôleur
        public IActionResult RedirectToDifferentController()
        {
            // Redirige vers l'action "Index" dans le contrôleur "Home"
            return RedirectToAction("Index", "Home");
        }

        // Action de redirection vers une URL externe
        public IActionResult RedirectToExternalUrl()
        {
            // Redirige vers une URL externe (ex. Google)
            return Redirect("https://www.google.com");
        }

        // Action cible pour la redirection
        public IActionResult TargetAction()
        {
            return Content("Vous avez été redirigé vers cette action.");
        }
    }
}

