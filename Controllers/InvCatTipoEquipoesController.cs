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
    public class InvCatTipoEquipoesController : Controller
    {
        private readonly InventarioContext _context;
        ValidateCoockie validateCoockie = new ValidateCoockie();

        public InvCatTipoEquipoesController(InventarioContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            bool isCoockie = Request.Cookies.ContainsKey("us3r4ct1v3");
            isCoockie = validateCoockie.GetCoockieExist(isCoockie);
            if (isCoockie != false)
            {
                return View(await _context.InvCatTipoEquipos.OrderBy(a=>a.Tipo).ToListAsync());
            }
            else
            {
                return RedirectToAction("UserNotFound", "Home");
            }
        }

        private bool InvCatTipoEquipoExists(int id)
        {
            return _context.InvCatTipoEquipos.Any(e => e.Id == id);
        }
    }
}
