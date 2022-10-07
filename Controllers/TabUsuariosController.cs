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
    public class TabUsuariosController : Controller
    {
        private readonly InventarioContext _context;
        ValidateCoockie validateCoockie = new ValidateCoockie();
        public TabUsuariosController(InventarioContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            bool isCoockie = Request.Cookies.ContainsKey("us3r4ct1v3");
            isCoockie = validateCoockie.GetCoockieExist(isCoockie);
            if (isCoockie != false)
            {
                var inventarioContext = _context.TabUsuarios.Include(t => t.IdDepartamentoNavigation).Include(t => t.IdPlantaNavigation).Include(t => t.IdPuestoNavigation);
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
            else
            {
                return RedirectToAction("UserNotFound", "Home");
            }
        }

        public IActionResult Create()
        {
            bool isCoockie = Request.Cookies.ContainsKey("us3r4ct1v3");
            isCoockie = validateCoockie.GetCoockieExist(isCoockie);
            if (isCoockie != false)
            {
                ViewData["IdDepartamento"] = new SelectList(_context.CatDepartamentos, "Id", "Abreviacion");
                ViewData["IDSitio"] = new SelectList(_context.CatPlanta, "IDSitio", "IDSitio");
                ViewData["IdPuesto"] = new SelectList(_context.CatPuestos, "Id", "Id");
                return View();
            }
            else
            {
                return RedirectToAction("UserNotFound", "Home");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NombreUsuario,Nombre,ApellidoPaterno,ApellidoMaterno,Correo,NumeroTelefonico,NumeroExtension,PstCorreo,UsuarioWindows,EsUsuarioSap,EsCorporativo,Password,IdPuesto,IdDepartamento,IDSitio,Activo,FechaCreacion")] TabUsuario tabUsuario)
        {
            bool isCoockie = Request.Cookies.ContainsKey("us3r4ct1v3");
            isCoockie = validateCoockie.GetCoockieExist(isCoockie);
            if (isCoockie != false)
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
            else
            {
                return RedirectToAction("UserNotFound", "Home");
            }
        }

        public async Task<IActionResult> Edit(int? id)
        {
            bool isCoockie = Request.Cookies.ContainsKey("us3r4ct1v3");
            isCoockie = validateCoockie.GetCoockieExist(isCoockie);
            if (isCoockie != false)
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
            else
            {
                return RedirectToAction("UserNotFound", "Home");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NombreUsuario,Nombre,ApellidoPaterno,ApellidoMaterno,Correo,NumeroTelefonico,NumeroExtension,PstCorreo,UsuarioWindows,EsUsuarioSap,EsCorporativo,Password,IdPuesto,IdDepartamento,IDSitio,Activo,FechaCreacion")] TabUsuario tabUsuario)
        {
            bool isCoockie = Request.Cookies.ContainsKey("us3r4ct1v3");
            isCoockie = validateCoockie.GetCoockieExist(isCoockie);
            if (isCoockie != false)
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
            else
            {
                return RedirectToAction("UserNotFound", "Home");
            }
        }

        public async Task<IActionResult> Delete(int? id)
        {
            bool isCoockie = Request.Cookies.ContainsKey("us3r4ct1v3");
            isCoockie = validateCoockie.GetCoockieExist(isCoockie);
            if (isCoockie != false)
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
            else
            {
                return RedirectToAction("UserNotFound", "Home");
            }
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            bool isCoockie = Request.Cookies.ContainsKey("us3r4ct1v3");
            isCoockie = validateCoockie.GetCoockieExist(isCoockie);
            if (isCoockie != false)
            {
                var tabUsuario = await _context.TabUsuarios.FindAsync(id);
                _context.TabUsuarios.Remove(tabUsuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return RedirectToAction("UserNotFound", "Home");
            }
        }

        private bool TabUsuarioExists(int id)
        {
            return _context.TabUsuarios.Any(e => e.Id == id);
        }
    }
}
