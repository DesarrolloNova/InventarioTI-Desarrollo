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
    public class InvHisAsignacionEquipoesController : Controller
    {
        private readonly InventarioContext _context;

        public InvHisAsignacionEquipoesController(InventarioContext context)
        {
            _context = context;
        }

        // GET: InvHisAsignacionEquipoes
        public async Task<IActionResult> Index()
        {
            var inventarioContext = _context.InvHisAsignacionEquipos.Include(i => i.IdEquipoNavigation);
            return View(await inventarioContext.ToListAsync());
        }

        // GET: InvHisAsignacionEquipoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invHisAsignacionEquipo = await _context.InvHisAsignacionEquipos
                .Include(i => i.IdEquipoNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (invHisAsignacionEquipo == null)
            {
                return NotFound();
            }

            return View(invHisAsignacionEquipo);
        }

        // GET: InvHisAsignacionEquipoes/Create
        public IActionResult Create()
        {
            ViewData["IdEquipo"] = new SelectList(_context.InvTabEquipos, "Id", "DireccionMac");
            return View();
        }

        // POST: InvHisAsignacionEquipoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FechaInicio,FechaFin,EnDominio,TipoConexion,Ip,IdEquipo,IdDepartamento,Activo")] InvHisAsignacionEquipo invHisAsignacionEquipo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(invHisAsignacionEquipo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdEquipo"] = new SelectList(_context.InvTabEquipos, "Id", "DireccionMac", invHisAsignacionEquipo.IdEquipo);
            return View(invHisAsignacionEquipo);
        }

        // GET: InvHisAsignacionEquipoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invHisAsignacionEquipo = await _context.InvHisAsignacionEquipos.FindAsync(id);
            if (invHisAsignacionEquipo == null)
            {
                return NotFound();
            }
            ViewData["IdEquipo"] = new SelectList(_context.InvTabEquipos, "Id", "DireccionMac", invHisAsignacionEquipo.IdEquipo);
            return View(invHisAsignacionEquipo);
        }

        // POST: InvHisAsignacionEquipoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FechaInicio,FechaFin,EnDominio,TipoConexion,Ip,IdEquipo,IdDepartamento,Activo")] InvHisAsignacionEquipo invHisAsignacionEquipo)
        {
            if (id != invHisAsignacionEquipo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(invHisAsignacionEquipo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InvHisAsignacionEquipoExists(invHisAsignacionEquipo.Id))
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
            ViewData["IdEquipo"] = new SelectList(_context.InvTabEquipos, "Id", "DireccionMac", invHisAsignacionEquipo.IdEquipo);
            return View(invHisAsignacionEquipo);
        }

        // GET: InvHisAsignacionEquipoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invHisAsignacionEquipo = await _context.InvHisAsignacionEquipos
                .Include(i => i.IdEquipoNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (invHisAsignacionEquipo == null)
            {
                return NotFound();
            }

            return View(invHisAsignacionEquipo);
        }

        // POST: InvHisAsignacionEquipoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var invHisAsignacionEquipo = await _context.InvHisAsignacionEquipos.FindAsync(id);
            _context.InvHisAsignacionEquipos.Remove(invHisAsignacionEquipo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InvHisAsignacionEquipoExists(int id)
        {
            return _context.InvHisAsignacionEquipos.Any(e => e.Id == id);
        }
    }
}
