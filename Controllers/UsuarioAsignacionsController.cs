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
    public class UsuarioAsignacionsController : Controller
    {
        private readonly InventarioContext _context;
        ValidateCoockie validateCoockie = new ValidateCoockie();
        public UsuarioAsignacionsController(InventarioContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult VerAsignacionIndividual(int idUsuarioAsignacion)
        {
            bool isCoockie = Request.Cookies.ContainsKey("us3r4ct1v3");
            isCoockie = validateCoockie.GetCoockieExist(isCoockie);
            if (isCoockie != false)
            {
                InventarioContext context = new InventarioContext();
                UsuarioAsignacion usuarioAsignacion = new UsuarioAsignacion();
                usuarioAsignacion = context.UsuarioAsignacion.Where(ua => ua.idUsuarioAsignacion == idUsuarioAsignacion).FirstOrDefault();
                if (usuarioAsignacion == null)
                {
                    return NotFound();
                }

                return View(usuarioAsignacion);
            }
            else
            {
                return RedirectToAction("UserNotFound", "Home");
            }
        }
    }
}
