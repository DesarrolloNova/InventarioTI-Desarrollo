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
    public class UsuarioLicenciasController : Controller
    {
        private readonly InventarioContext _context;
        ValidateCoockie validateCoockie = new ValidateCoockie();

        public UsuarioLicenciasController(InventarioContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            bool isCoockie = Request.Cookies.ContainsKey("us3r4ct1v3");
            isCoockie = validateCoockie.GetCoockieExist(isCoockie);
            if (isCoockie != false)
            {
                return View(await _context.UsuarioLicencias.ToListAsync());
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

                var usuarioLicencias = await _context.UsuarioLicencias
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (usuarioLicencias == null)
                {
                    return NotFound();
                }

                return View(usuarioLicencias);
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
                return View();
            }
            else
            {
                return RedirectToAction("UserNotFound", "Home");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdEmpleado,IdAsignacion")] UsuarioLicencias usuarioLicencias)
        {
            bool isCoockie = Request.Cookies.ContainsKey("us3r4ct1v3");
            isCoockie = validateCoockie.GetCoockieExist(isCoockie);
            if (isCoockie != false)
            {
                if (ModelState.IsValid)
                {
                    _context.Add(usuarioLicencias);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(usuarioLicencias);
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

                var usuarioLicencias = await _context.UsuarioLicencias.FindAsync(id);
                if (usuarioLicencias == null)
                {
                    return NotFound();
                }
                return View(usuarioLicencias);
            }
            else
            {
                return RedirectToAction("UserNotFound", "Home");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdEmpleado,IdAsignacion")] UsuarioLicencias usuarioLicencias)
        {
            bool isCoockie = Request.Cookies.ContainsKey("us3r4ct1v3");
            isCoockie = validateCoockie.GetCoockieExist(isCoockie);
            if (isCoockie != false)
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

                var usuarioLicencias = await _context.UsuarioLicencias
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (usuarioLicencias == null)
                {
                    return NotFound();
                }

                return View(usuarioLicencias);
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
                var usuarioLicencias = await _context.UsuarioLicencias.FindAsync(id);
                _context.UsuarioLicencias.Remove(usuarioLicencias);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return RedirectToAction("UserNotFound", "Home");
            }
        }

        private bool UsuarioLicenciasExists(int id)
        {
            return _context.UsuarioLicencias.Any(e => e.Id == id);
        }
    }
}
