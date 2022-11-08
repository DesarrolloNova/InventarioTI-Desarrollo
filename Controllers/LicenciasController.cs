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
    public class LicenciasController : Controller
    {
        private readonly InventarioContext _context;
        ValidateCoockie validateCoockie = new ValidateCoockie();

        public LicenciasController(InventarioContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            bool isCoockie = Request.Cookies.ContainsKey("us3r4ct1v3");
            isCoockie = validateCoockie.GetCoockieExist(isCoockie);
            if (isCoockie != false)
            {
                List<Licencias> licencias = new List<Licencias>();
                licencias = _context.Licencias.ToList();
                return View(licencias);
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

                var licencias = await _context.Licencias
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (licencias == null)
                {
                    return NotFound();
                }

                return View(licencias);
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
        public async Task<IActionResult> Create([Bind("Id,Marca,Descripcion,Tipo,Usuario,Clave,CodigoProducto,InicioVigencia,FinVigencia,Cantidad")] Licencias licencias)
        {
            bool isCoockie = Request.Cookies.ContainsKey("us3r4ct1v3");
            isCoockie = validateCoockie.GetCoockieExist(isCoockie);
            if (isCoockie != false)
            {
                if (ModelState.IsValid)
                {
                    _context.Add(licencias);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(licencias);
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

                var licencias = await _context.Licencias.FindAsync(id);
                if (licencias == null)
                {
                    return NotFound();
                }
                return View(licencias);
            }
            else
            {
                return RedirectToAction("UserNotFound", "Home");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Marca,Descripcion,Tipo,Usuario,Clave,CodigoProducto,InicioVigencia,FinVigencia,Cantidad")] Licencias licencias)
        {
            bool isCoockie = Request.Cookies.ContainsKey("us3r4ct1v3");
            isCoockie = validateCoockie.GetCoockieExist(isCoockie);
            if (isCoockie != false)
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

                var licencias = await _context.Licencias
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (licencias == null)
                {
                    return NotFound();
                }

                return View(licencias);
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
                var licencias = await _context.Licencias.FindAsync(id);
                _context.Licencias.Remove(licencias);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return RedirectToAction("UserNotFound", "Home");
            }
        }

        private bool LicenciasExists(int id)
        {
            return _context.Licencias.Any(e => e.Id == id);
        }
    }
}
