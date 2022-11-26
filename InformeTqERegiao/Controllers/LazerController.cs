using Microsoft.AspNetCore.Mvc;

namespace InformeTqERegiao.Controllers
{
    public class LazerController : Controller
    {
        public IActionResult Restaurantes()
        {
            return View();
        }
        public IActionResult Sorveterias()
        {
            return View();
        }
        public IActionResult Bares()
        {
            return View();
        }
        public IActionResult Areas()
        {
            return View();
        }
    }
}
