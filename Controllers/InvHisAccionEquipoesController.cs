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
    public class InvHisAccionEquipoesController : Controller
    {
        private readonly InventarioContext _context;

        public InvHisAccionEquipoesController(InventarioContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index(int idEquipo)
        {
            var inventarioContext = _context.InvHisAccionEquipos.Where(a => a.IdEquipo == idEquipo);
            return View(await inventarioContext.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
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

        //public IActionResult Create()
        //{
        //    ViewData["IdAsignacion"] = new SelectList(_context.InvHisAsignacionEquipos, "Id", "Ip");
        //    ViewData["IdEquipo"] = new SelectList(_context.InvTabEquipos, "Id", "DireccionMac");
        //    ViewData["IdUsuarioRegistro"] = new SelectList(_context.TabUsuarios, "Id", "Nombre");
        //    return View();
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,FechaInicio,FechaFin,TipoProceso,IdAsignacion,IdEquipo,IdUsuarioRegistro")] InvHisAccionEquipo invHisAccionEquipo)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(invHisAccionEquipo);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["IdAsignacion"] = new SelectList(_context.InvHisAsignacionEquipos, "Id", "Ip", invHisAccionEquipo.IdAsignacion);
        //    ViewData["IdEquipo"] = new SelectList(_context.InvTabEquipos, "Id", "DireccionMac", invHisAccionEquipo.IdEquipo);
        //    ViewData["IdUsuarioRegistro"] = new SelectList(_context.TabUsuarios, "Id", "Nombre", invHisAccionEquipo.IdUsuarioRegistro);
        //    return View(invHisAccionEquipo);
        //}

        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var invHisAccionEquipo = await _context.InvHisAccionEquipos.FindAsync(id);
        //    if (invHisAccionEquipo == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["IdAsignacion"] = new SelectList(_context.InvHisAsignacionEquipos, "Id", "Ip", invHisAccionEquipo.IdAsignacion);
        //    ViewData["IdEquipo"] = new SelectList(_context.InvTabEquipos, "Id", "DireccionMac", invHisAccionEquipo.IdEquipo);
        //    ViewData["IdUsuarioRegistro"] = new SelectList(_context.TabUsuarios, "Id", "Nombre", invHisAccionEquipo.IdUsuarioRegistro);
        //    return View(invHisAccionEquipo);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,FechaInicio,FechaFin,TipoProceso,IdAsignacion,IdEquipo,IdUsuarioRegistro")] InvHisAccionEquipo invHisAccionEquipo)
        //{
        //    if (id != invHisAccionEquipo.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(invHisAccionEquipo);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!InvHisAccionEquipoExists(invHisAccionEquipo.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["IdAsignacion"] = new SelectList(_context.InvHisAsignacionEquipos, "Id", "Ip", invHisAccionEquipo.IdAsignacion);
        //    ViewData["IdEquipo"] = new SelectList(_context.InvTabEquipos, "Id", "DireccionMac", invHisAccionEquipo.IdEquipo);
        //    ViewData["IdUsuarioRegistro"] = new SelectList(_context.TabUsuarios, "Id", "Nombre", invHisAccionEquipo.IdUsuarioRegistro);
        //    return View(invHisAccionEquipo);
        //}

        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var invHisAccionEquipo = await _context.InvHisAccionEquipos
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (invHisAccionEquipo == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(invHisAccionEquipo);
        //}

        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var invHisAccionEquipo = await _context.InvHisAccionEquipos.FindAsync(id);
        //    _context.InvHisAccionEquipos.Remove(invHisAccionEquipo);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool InvHisAccionEquipoExists(int id)
        //{
        //    return _context.InvHisAccionEquipos.Any(e => e.Id == id);
        //}
    }
}
