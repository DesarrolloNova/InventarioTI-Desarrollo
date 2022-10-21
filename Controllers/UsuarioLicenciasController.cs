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
    public class UsuarioLicenciasController : Controller
    {
        private readonly InventarioContext _context;

        public UsuarioLicenciasController(InventarioContext context)
        {
            _context = context;
        }

        // GET: UsuarioLicencias
        public async Task<IActionResult> Index()
        {
            return View(await _context.UsuarioLicencias.ToListAsync());
        }

        // GET: UsuarioLicencias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarioLicencias = await _context.UsuarioLicencias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuarioLicencias == null)
            {
                return NotFound();
            }

            return View(usuarioLicencias);
        }

        // GET: UsuarioLicencias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UsuarioLicencias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdEmpleado,IdAsignacion")] UsuarioLicencias usuarioLicencias)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuarioLicencias);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuarioLicencias);
        }

        // GET: UsuarioLicencias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarioLicencias = await _context.UsuarioLicencias.FindAsync(id);
            if (usuarioLicencias == null)
            {
                return NotFound();
            }
            return View(usuarioLicencias);
        }

        // POST: UsuarioLicencias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdEmpleado,IdAsignacion")] UsuarioLicencias usuarioLicencias)
        {
            if (id != usuarioLicencias.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuarioLicencias);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioLicenciasExists(usuarioLicencias.Id))
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
            return View(usuarioLicencias);
        }

        // GET: UsuarioLicencias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarioLicencias = await _context.UsuarioLicencias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuarioLicencias == null)
            {
                return NotFound();
            }

            return View(usuarioLicencias);
        }

        // POST: UsuarioLicencias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuarioLicencias = await _context.UsuarioLicencias.FindAsync(id);
            _context.UsuarioLicencias.Remove(usuarioLicencias);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioLicenciasExists(int id)
        {
            return _context.UsuarioLicencias.Any(e => e.Id == id);
        }
    }
}
