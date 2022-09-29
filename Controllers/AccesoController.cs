using InventarioTI.Context;
using InventarioTI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace InventarioTI.Controllers
{
    public class AccesoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string correo, string clave)
        {
            TabUsuario usuario = new TabUsuario();

            try
            {
                InventarioContext context = new InventarioContext();
                usuario = await context.TabUsuarios.Where(u => u.Correo == correo && u.Password == clave).FirstOrDefaultAsync();
                if (usuario != null)
                {
                    //Agregar los claims
                    return RedirectToAction("Index","Home");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return View();
        }
    }
}
