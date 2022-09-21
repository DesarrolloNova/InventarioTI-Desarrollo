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
    public class TabUsuariosController : Controller
    {
        private readonly InventarioContext _context;

        public TabUsuariosController(InventarioContext context)
        {
            _context = context;
        }

        // GET: TabUsuarios
        public async Task<IActionResult> Index()
        {
            var inventarioContext = _context.TabUsuarios.Include(t => t.IdDepartamentoNavigation).Include(t => t.IdPlantaNavigation).Include(t => t.IdPuestoNavigation);
            return View(await inventarioContext.ToListAsync());
        }

        // GET: TabUsuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabUsuario = await _context.TabUsuarios
                .Include(t => t.IdDepartamentoNavigation)
                .Include(t => t.IdPlantaNavigation)
                .Include(t => t.IdPuestoNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tabUsuario == null)
            {
                return NotFound();
            }

            return View(tabUsuario);
        }

        // GET: TabUsuarios/Create
        public IActionResult Create()
        {
            ViewData["IdDepartamento"] = new SelectList(_context.CatDepartamentos, "Id", "Abreviacion");
            ViewData["IDSitio"] = new SelectList(_context.CatPlanta, "IDSitio", "IDSitio");
            ViewData["IdPuesto"] = new SelectList(_context.CatPuestos, "Id", "Id");
            return View();
        }

        // POST: TabUsuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NombreUsuario,Nombre,ApellidoPaterno,ApellidoMaterno,Correo,NumeroTelefonico,NumeroExtension,PstCorreo,UsuarioWindows,EsUsuarioSap,EsCorporativo,Password,IdPuesto,IdDepartamento,IDSitio,Activo,FechaCreacion")] TabUsuario tabUsuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tabUsuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdDepartamento"] = new SelectList(_context.CatDepartamentos, "Id", "Abreviacion", tabUsuario.IdDepartamento);
            ViewData["IDSitio"] = new SelectList(_context.CatPlanta, "IDSitio", "IDSitio", tabUsuario.IDSitio);
            ViewData["IdPuesto"] = new SelectList(_context.CatPuestos, "Id", "Id", tabUsuario.IdPuesto);
            return View(tabUsuario);
        }

        // GET: TabUsuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabUsuario = await _context.TabUsuarios.FindAsync(id);
            if (tabUsuario == null)
            {
                return NotFound();
            }
            ViewData["IdDepartamento"] = new SelectList(_context.CatDepartamentos, "Id", "Abreviacion", tabUsuario.IdDepartamento);
            ViewData["IDSitio"] = new SelectList(_context.CatPlanta, "IDSitio", "IDSitio", tabUsuario.IDSitio);
            ViewData["IdPuesto"] = new SelectList(_context.CatPuestos, "Id", "Id", tabUsuario.IdPuesto);
            return View(tabUsuario);
        }

        // POST: TabUsuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NombreUsuario,Nombre,ApellidoPaterno,ApellidoMaterno,Correo,NumeroTelefonico,NumeroExtension,PstCorreo,UsuarioWindows,EsUsuarioSap,EsCorporativo,Password,IdPuesto,IdDepartamento,IDSitio,Activo,FechaCreacion")] TabUsuario tabUsuario)
        {
            if (id != tabUsuario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tabUsuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TabUsuarioExists(tabUsuario.Id))
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
            ViewData["IdDepartamento"] = new SelectList(_context.CatDepartamentos, "Id", "Abreviacion", tabUsuario.IdDepartamento);
            ViewData["IDSitio"] = new SelectList(_context.CatPlanta, "IDSitio", "IDSitio", tabUsuario.IDSitio);
            ViewData["IdPuesto"] = new SelectList(_context.CatPuestos, "Id", "Id", tabUsuario.IdPuesto);
            return View(tabUsuario);
        }

        // GET: TabUsuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabUsuario = await _context.TabUsuarios
                .Include(t => t.IdDepartamentoNavigation)
                .Include(t => t.IdPlantaNavigation)
                .Include(t => t.IdPuestoNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tabUsuario == null)
            {
                return NotFound();
            }

            return View(tabUsuario);
        }

        // POST: TabUsuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tabUsuario = await _context.TabUsuarios.FindAsync(id);
            _context.TabUsuarios.Remove(tabUsuario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TabUsuarioExists(int id)
        {
            return _context.TabUsuarios.Any(e => e.Id == id);
        }
    }
}
