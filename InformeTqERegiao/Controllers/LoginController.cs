using InformeTqERegiao.Entidades;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace InformeTqERegiao.Controllers
{
    public class LoginController : Controller
    {
        private readonly Contexto db;

        public LoginController(Contexto contexto)
        {
            db = contexto;
        }
        public IActionResult Entrar()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Entrar(string Email, string Senha)
        {
            Usuarios usuarioLogado = db.USUARIOS.Where(a => a.Email == Email && a.Senha == Senha).FirstOrDefault();

            if(usuarioLogado == null)
            {
                TempData["erro"] = "Usuário e senha inválidos";
                return View();
            }

            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, usuarioLogado.Nome));
            claims.Add(new Claim(ClaimTypes.Sid, usuarioLogado.Id.ToString()));

            var userIdentity = new ClaimsIdentity(claims, "Acesso");

            ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
            await HttpContext.SignInAsync("CookieAuthentication", principal, new AuthenticationProperties());

            return Redirect("/");
        }

        public async Task<IActionResult> Logoff()
        {
            await HttpContext.SignOutAsync("CookieAuthentication");
            return Redirect("/Login/Entrar");
        }

        public IActionResult Sucesso()
        {
            return View();
        }

        public IActionResult Certezasair()
        {
            return View();
        }


    }
}
