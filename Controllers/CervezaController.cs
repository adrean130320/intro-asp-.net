
using introAsp.Models;
using introAsp.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace introAsp.Controllers
{
    public class CervezaController : Controller
    {
        private readonly tareaContext _context;

        public CervezaController(tareaContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var cervezas =_context.Cervezas.Include( m=>m.MarcaNavigation );
            return View(await cervezas.ToListAsync());
        }

        public IActionResult create()
        {
            ViewData["Marcas"] = new SelectList(_context.Marcas, "Id", "Marca1");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> create(CervezaViewModel model)
        {
            if ( ModelState.IsValid )
            {
                var cerveza = new Cerveza()
                {
                    Nombre=model.Nombre,
                    Marca = model.Marca
                };
                _context.Add(cerveza);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }


           
            return View(model);
        }

    }
}
