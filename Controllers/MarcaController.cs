using introAsp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace introAsp.Controllers
{
    public class MarcaController : Controller
    {

        private readonly tareaContext _context;

        public MarcaController(tareaContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {

            return View(await _context.Marcas.ToListAsync());
        }
    }
}
