using InventarioTI.Context;
using InventarioTI.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace InventarioTI.Controllers
{
    public class AccountController : Controller
    {
        InventarioContext context = new InventarioContext();
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string correo, string password)
        {
            TabUsuario usuario = new TabUsuario();
            usuario = context.TabUsuarios.Where(u => u.Correo == correo && u.Password == password).FirstOrDefault();
            if (usuario == null)
            {
                ViewData["MENSAJE"] = "Tus credenciales no son correctas";
                return View();
            }
            else
            {
                try
                {
                    ClaimsIdentity identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);

                    Claim claimUserName = new Claim(ClaimTypes.Name, usuario.Nombre + " " + usuario.ApellidoPaterno + " " + usuario.ApellidoMaterno);
                    Claim claimRole = new Claim(ClaimTypes.Role, usuario.IdPuesto.ToString());
                    Claim claimIdUsuario = new Claim("UsuarioId", usuario.Id.ToString());
                    Claim claimCorreo = new Claim("CorreoUsuario", usuario.Correo);

                    identity.AddClaim(claimUserName);
                    identity.AddClaim(claimRole);
                    identity.AddClaim(claimIdUsuario);
                    identity.AddClaim(claimCorreo);

                    ClaimsPrincipal userPrincipal = new ClaimsPrincipal(identity);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, userPrincipal, new AuthenticationProperties
                    {

                        ExpiresUtc = DateTime.Now.AddMinutes(45)
                    });

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return RedirectToAction("Index","Home");
            }
        }

        public IActionResult ErrorAcceso()
        {
            ViewData["MENSAJE"] = "Error de Acceso";
            return View();
        }

        public async Task<IActionResult> CerrarSesion()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index","Home");
        }
    }
}
