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
    public class UsuarioAsignacionsController : Controller
    {
        private readonly InventarioContext _context;

        public UsuarioAsignacionsController(InventarioContext context)
        {
            _context = context;
        }

        // GET: UsuarioAsignacions
        public async Task<IActionResult> Index()
        {
            return View(await _context.UsuarioAsignacion.ToListAsync());
        }

        // GET: UsuarioAsignacions/Details/5
        public async Task<IActionResult> Details(int? id, int idAsignacion)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarioAsignacion = await _context.UsuarioAsignacion
                .FirstOrDefaultAsync(m => m.IdEmpleado == id && m.IdAsignacion == idAsignacion);
            if (usuarioAsignacion == null)
            {
                return NotFound();
            }

            return View(usuarioAsignacion);
        }

        // GET: UsuarioAsignacions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UsuarioAsignacions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdUsuario,IdAsignacion,FechaInicioAsignacion,FechaFinAsignacion,Asignado")] UsuarioAsignacion usuarioAsignacion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuarioAsignacion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuarioAsignacion);
        }

        // GET: UsuarioAsignacions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarioAsignacion = await _context.UsuarioAsignacion.FindAsync(id);
            if (usuarioAsignacion == null)
            {
                return NotFound();
            }
            return View(usuarioAsignacion);
        }

        // POST: UsuarioAsignacions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdUsuario,IdAsignacion,FechaInicioAsignacion,FechaFinAsignacion,Asignado")] UsuarioAsignacion usuarioAsignacion)
        {
            if (id != usuarioAsignacion.IdEmpleado)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuarioAsignacion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioAsignacionExists(usuarioAsignacion.IdEmpleado))
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
            return View(usuarioAsignacion);
        }

        // GET: UsuarioAsignacions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarioAsignacion = await _context.UsuarioAsignacion
                .FirstOrDefaultAsync(m => m.IdEmpleado == id);
            if (usuarioAsignacion == null)
            {
                return NotFound();
            }

            return View(usuarioAsignacion);
        }

        // POST: UsuarioAsignacions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuarioAsignacion = await _context.UsuarioAsignacion.FindAsync(id);
            _context.UsuarioAsignacion.Remove(usuarioAsignacion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioAsignacionExists(int id)
        {
            return _context.UsuarioAsignacion.Any(e => e.IdEmpleado == id);
        }
    }
}
