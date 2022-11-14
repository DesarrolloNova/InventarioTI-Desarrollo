using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InventarioTI.Context;
using InventarioTI.Models;
using InventarioTI.Tools;

namespace InventarioTI.Controllers
{
    public class UsuarioLicenciasController : Controller
    {
        private readonly InventarioContext _context;
        ValidateCoockie validateCoockie = new ValidateCoockie();

        public UsuarioLicenciasController(InventarioContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult VerAsignacionIndividual(int idUsuarioLicencia)
        {
            bool isCoockie = Request.Cookies.ContainsKey("us3r4ct1v3");
            isCoockie = validateCoockie.GetCoockieExist(isCoockie);
            if (isCoockie != false)
            {
                InventarioContext context = new InventarioContext();
                UsuarioLicencias usuarioLicencia = new UsuarioLicencias();
                usuarioLicencia = context.UsuarioLicencias.Where(ua => ua.Id == idUsuarioLicencia).FirstOrDefault();
                if (usuarioLicencia == null)
                {
                    return NotFound();
                }

                return View(usuarioLicencia);
            }
            else
            {
                return RedirectToAction("UserNotFound", "Home");
            }
        }
    }
}
