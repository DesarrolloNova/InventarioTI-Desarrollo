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
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InventarioTI.Controllers
{
    public class InvHisAccionEquipoesController : Controller
    {
        private readonly InventarioContext _context;
        ValidateCoockie validateCoockie = new ValidateCoockie();
        public InvHisAccionEquipoesController(InventarioContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index(int idEquipo)
        {
            bool isCoockie = Request.Cookies.ContainsKey("us3r4ct1v3");
            isCoockie = validateCoockie.GetCoockieExist(isCoockie);
            if (isCoockie != false)
            {
                var inventarioContext = _context.InvHisAccionEquipos.Where(a => a.IdEquipo == idEquipo);
                return View(await inventarioContext.ToListAsync());
            }
            else
            {
                return RedirectToAction("UserNotFound", "Home");
            }
        }

        public async Task<IActionResult> Details(int? id)
        {
            bool isCoockie = Request.Cookies.ContainsKey("us3r4ct1v3");
            isCoockie = validateCoockie.GetCoockieExist(isCoockie);
            if (isCoockie != false)
            {

                if (id == null)
                {
                    return NotFound();
                }

                var invHisAccionEquipo = await _context.InvHisAccionEquipos
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (invHisAccionEquipo == null)
                {
                    return NotFound();
                }

                return View(invHisAccionEquipo);
            }
            else
            {
                return RedirectToAction("UserNotFound", "Home");
            }

        }
    }
}
