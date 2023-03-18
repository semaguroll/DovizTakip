using DovizTakip.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DovizTakip.Controllers
{
    public class CurrencyController : Controller
    {
        private DovizKurContext _context { get; }

        public CurrencyController(DovizKurContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            var list = this._context.DovizKurlari.ToList();

            //Filtreleme yap

            return View(list);
        }
    }
}
