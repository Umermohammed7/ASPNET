using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProduitController : Controller
    {
        private readonly Myctx _context;

        public ProduitController(Myctx context) {  _context = context; }

        //public IActionResult Commentaire()
        //{
        //    return View();
        //}
    
        //public IActionResult ModifierStock()
        //{
        //    return View();
        //}
        //public IActionResult AjouterProduit()
        //{
        //    return View();
        //}
        //public IActionResult ModifierProduit()
        //{
        //    return View();
        //}
        //public IActionResult SupprimerProduit()
        //{
        //    return View();
        //}

        public IActionResult Index() 
        {  
            
            return View(_context.Produits.ToList()); 
        }


        [HttpGet] //Affichage du formulaire
        public IActionResult Create() { 
        
            return View();
        }



        [HttpPost] //Vérification du formulaire et validation
        public IActionResult Create([Bind("Id,Name,Price")] Produit produit)
        {
            if (ModelState.IsValid) {
                _context.Add(produit);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(produit);
        }

        public IActionResult Details(int? id)
        {

            if(id == null)
            {
                return NotFound();
            }

            var produit = _context.Produits.FirstOrDefault(m => m.Id == id);
            if (produit == null)
            {
                return NotFound();
            }

            return View(produit);
        }

        public IActionResult Edit(int id, [Bind("Id,Name,Price")] Produit produit)
        {
            if (id != produit.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(produit);
                    _context.SaveChanges();
                }
                catch(DbUpdateConcurrencyException)
                {
                    if(!ProduitExists(produit.Id))
                    {
                        return NotFound();
                    } else
                    {
                        throw;
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            return View(produit);
        }


        public IActionResult Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var produit = _context.Produits.FirstOrDefault(m => m.Id == id);
            if(produit == null)
            {
                return NotFound();
            }

            return View(produit);
        }

        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var produit = _context.Produits.Find(id);
            if(produit != null)
            {
                _context.Produits.Remove(produit);
            }
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }






        private bool ProduitExists(int id) {
            return _context.Produits.Any(e => e.Id == id);
        }




    }
}
