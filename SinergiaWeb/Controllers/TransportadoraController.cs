using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SinergiaWeb.Controllers
{
    public class TransportadoraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}