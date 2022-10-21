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
    public class LicenciasController : Controller
    {
        private readonly InventarioContext _context;

        public LicenciasController(InventarioContext context)
        {
            _context = context;
        }

        // GET: Licencias
        public async Task<IActionResult> Index()
        {
            List<Licencias> licencias = new List<Licencias>();
            licencias = _context.Licencias.ToList();
            return View(licencias);
        }

        // GET: Licencias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var licencias = await _context.Licencias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (licencias == null)
            {
                return NotFound();
            }

            return View(licencias);
        }

        // GET: Licencias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Licencias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Marca,Descripcion,Tipo,Usuario,Clave,CodigoProducto,InicioVigencia,FinVigencia")] Licencias licencias)
        {
            if (ModelState.IsValid)
            {
                _context.Add(licencias);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(licencias);
        }

        // GET: Licencias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var licencias = await _context.Licencias.FindAsync(id);
            if (licencias == null)
            {
                return NotFound();
            }
            return View(licencias);
        }

        // POST: Licencias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Marca,Descripcion,Tipo,Usuario,Clave,CodigoProducto,InicioVigencia,FinVigencia")] Licencias licencias)
        {
            if (id != licencias.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(licencias);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LicenciasExists(licencias.Id))
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
            return View(licencias);
        }

        // GET: Licencias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var licencias = await _context.Licencias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (licencias == null)
            {
                return NotFound();
            }

            return View(licencias);
        }

        // POST: Licencias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var licencias = await _context.Licencias.FindAsync(id);
            _context.Licencias.Remove(licencias);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LicenciasExists(int id)
        {
            return _context.Licencias.Any(e => e.Id == id);
        }
    }
}
