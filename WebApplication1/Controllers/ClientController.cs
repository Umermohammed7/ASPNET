using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ClientController : Controller
    {
        private readonly Myctx _context;
    public ClientController(Myctx context) { _context = context; }
    
        public IActionResult Index()
        {
            return View(_context.Clients.ToList());
        }

        [HttpGet] //Affichage du formulaire
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost] //Vérification du formulaire et validation
        public IActionResult Create([Bind("Id,Name,Prenom")] Client client)
        {
            if (ModelState.IsValid)
            {
                _context.Add(client);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(client);
        }

        public IActionResult Details(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var client = _context.Clients.FirstOrDefault(m => m.Id == id);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }


        public IActionResult Edit(int id, [Bind("Id,Name,Prenom")] Client client)
        {
            if (id != client.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(client);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientExists(client.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            return View(client);
        }



        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = _context.Clients.FirstOrDefault(m => m.Id == id);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var client = _context.Clients.Find(id);
            if (client != null)
            {
                _context.Clients.Remove(client);
            }
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }




        private bool ClientExists(int id)
        {
            return _context.Clients.Any(e => e.Id == id);
        }



    }
}
