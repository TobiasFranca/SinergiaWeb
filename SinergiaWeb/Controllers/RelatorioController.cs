using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SinergiaWeb.Controllers
{
    public class RelatorioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult VendasTotal()
        {
            return View();
        }

        public IActionResult VendasPorCliente()
        {
            return View();
        }

        public IActionResult VendasPorVendedor()
        {
            return View();
        }

        public IActionResult ItensMaisVendidos()
        {
            return View();
        }
    }
}