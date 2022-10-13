using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InventarioTI.Context;
using InventarioTI.Models;

namespace InventarioTI.Controllers
{
    public class InvCatEstatusEquipoesController : Controller
    {
        private readonly InventarioContext _context;

        public InvCatEstatusEquipoesController(InventarioContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.InvCatEstatusEquipos.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Estatus,Descripcion")] InvCatEstatusEquipo invCatEstatusEquipo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(invCatEstatusEquipo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(invCatEstatusEquipo);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invCatEstatusEquipo = await _context.InvCatEstatusEquipos.FindAsync(id);
            if (invCatEstatusEquipo == null)
            {
                return NotFound();
            }
            return View(invCatEstatusEquipo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Estatus,Descripcion")] InvCatEstatusEquipo invCatEstatusEquipo)
        {
            if (id != invCatEstatusEquipo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(invCatEstatusEquipo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InvCatEstatusEquipoExists(invCatEstatusEquipo.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(invCatEstatusEquipo);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invCatEstatusEquipo = await _context.InvCatEstatusEquipos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (invCatEstatusEquipo == null)
            {
                return NotFound();
            }

            return View(invCatEstatusEquipo);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var invCatEstatusEquipo = await _context.InvCatEstatusEquipos.FindAsync(id);
            _context.InvCatEstatusEquipos.Remove(invCatEstatusEquipo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InvCatEstatusEquipoExists(int id)
        {
            return _context.InvCatEstatusEquipos.Any(e => e.Id == id);
        }
    }
}
