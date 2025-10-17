using BibliotecaMetropolis.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaMetropolis.Controllers
{
    public class MaterialesController : Controller
    // Inicializamos la lista con un objeto vacío
   
        {
        private static List<MaterialesBiblioteca> materiales = new List<MaterialesBiblioteca>();

        // GET: /Materiales/Index
        public IActionResult Index()
        {
            return View(materiales);
        }

        // GET: /Materiales/Crear
        public IActionResult Crear()
        {
            return View(new MaterialesBiblioteca());
        }

        public IActionResult Ver()
        {
            // Muestra la lista actual de materiales
            return View(materiales);
        }

        // POST: /Materiales/Crear
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(MaterialesBiblioteca material)
        {
            if (ModelState.IsValid)
            {
                materiales.Add(material);
                return RedirectToAction("Index");
            }

            return View(material);
        }
    }
}