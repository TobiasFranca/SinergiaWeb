using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SinergiaWeb.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Detalhes()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult Estoque()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}