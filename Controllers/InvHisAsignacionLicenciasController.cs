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
    public class InvHisAsignacionLicenciasController : Controller
    {
        private readonly InventarioContext _context;
        ValidateCoockie validateCoockie = new ValidateCoockie();

        public InvHisAsignacionLicenciasController(InventarioContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int idLicencia)
        {
            bool isCoockie = Request.Cookies.ContainsKey("us3r4ct1v3");
            isCoockie = validateCoockie.GetCoockieExist(isCoockie);
            if (isCoockie != false)
            {
                return View(await _context.InvHisAsignacionLicencia.Where(al=>al.IdLicencia == idLicencia && al.Activo == false).ToListAsync());
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

                var invHisAsignacionLicencia = await _context.InvHisAsignacionLicencia
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (invHisAsignacionLicencia == null)
                {
                    return NotFound();
                }

                return View(invHisAsignacionLicencia);
            }
            else
            {
                return RedirectToAction("UserNotFound", "Home");
            }
        }

        public IActionResult Create(int idLicencia)
        {
            bool isCoockie = Request.Cookies.ContainsKey("us3r4ct1v3");
            isCoockie = validateCoockie.GetCoockieExist(isCoockie);
            if (isCoockie != false)
            {
                InvHisAsignacionLicencia asignacionLicencia = new InvHisAsignacionLicencia();
                asignacionLicencia.IdLicencia = idLicencia;
                return View(asignacionLicencia);
            }
            else
            {
                return RedirectToAction("UserNotFound", "Home");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Activo,IDSitio,ID_Area,IdLicencia")] InvHisAsignacionLicencia invHisAsignacionLicencia)
        {
            if (ModelState.IsValid)
            {
                invHisAsignacionLicencia.FechaInicio = DateTime.Now;
                invHisAsignacionLicencia.Activo = true;
                _context.Add(invHisAsignacionLicencia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(invHisAsignacionLicencia);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invHisAsignacionLicencia = await _context.InvHisAsignacionLicencia.FindAsync(id);
            if (invHisAsignacionLicencia == null)
            {
                return NotFound();
            }
            return View(invHisAsignacionLicencia);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FechaInicio,FechaFin,Activo,IDSitio,ID_Area")] InvHisAsignacionLicencia invHisAsignacionLicencia)
        {
            if (id != invHisAsignacionLicencia.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(invHisAsignacionLicencia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InvHisAsignacionLicenciaExists(invHisAsignacionLicencia.Id))
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
            return View(invHisAsignacionLicencia);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invHisAsignacionLicencia = await _context.InvHisAsignacionLicencia
                .FirstOrDefaultAsync(m => m.Id == id);
            if (invHisAsignacionLicencia == null)
            {
                return NotFound();
            }

            return View(invHisAsignacionLicencia);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var invHisAsignacionLicencia = await _context.InvHisAsignacionLicencia.FindAsync(id);
            _context.InvHisAsignacionLicencia.Remove(invHisAsignacionLicencia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InvHisAsignacionLicenciaExists(int id)
        {
            return _context.InvHisAsignacionLicencia.Any(e => e.Id == id);
        }
    }
}
