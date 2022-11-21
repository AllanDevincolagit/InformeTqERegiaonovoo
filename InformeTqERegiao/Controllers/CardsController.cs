using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformeTqERegiao.Controllers
{
    public class CardsController : Controller
    {
        public IActionResult Saude()
        {
            return View();
        }

        public IActionResult Compras()
        {
            return View();
        }

        public IActionResult Lazer()
        {
            return View();
        }

        public IActionResult Servicos()
        {
            return View();
        }
    }
}
