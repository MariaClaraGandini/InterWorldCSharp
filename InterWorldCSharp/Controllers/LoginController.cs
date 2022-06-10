using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterWorldCSharp.Entidades;
using System.Security.Claims;

namespace InterWorldCSharp.Controllers
{
    public class LoginController : Controller
    {
        private readonly Context db;

        public LoginController(Context context)
        {
            db=context;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Login (string Login,string Senha)
        {
            Usuarios usuarioLogado = db.USUARIOS.Where(a => a.Login == Login && a.Senha == Senha).FirstOrDefault();

            if (usuarioLogado == null)
            {
                TempData["erro"] = "Usuario e senha inválidos";
                return Redirect("/Home/Login");
            }

            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, usuarioLogado.Nome));
            claims.Add(new Claim(ClaimTypes.Sid, usuarioLogado.Id.ToString()));

            var userIdentity = new ClaimsIdentity (claims, "Acesso" );

            ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
            await HttpContext.SignInAsync("CookieAuthentication",principal, new AuthenticationProperties());

            return Redirect("/");
        }
        public async Task<IActionResult> Logoff()
        {
            await HttpContext.SignOutAsync("CookieAuthentication");
            return Redirect("/Home/Login");
        }

    }
}

