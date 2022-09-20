using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InventarioTI.Context;
using InventarioTI.Models;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Authorization;

namespace InventarioTI.Controllers
{
    public class InvTabEquipoesController : Controller
    {
        private readonly InventarioContext _context;

        public InvTabEquipoesController(InventarioContext context)
        {
            _context = context;
        }

        [Authorize]
        public async Task<IActionResult> Asignacion(int Id)
        { 
            InvHisAsignacionEquipo asignacionEquipo = new InvHisAsignacionEquipo();
            asignacionEquipo.IdEquipo = Id;
            return View(asignacionEquipo);
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            return View(await _context.InvTabEquipos.ToListAsync());
        }


        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invTabEquipo = await _context.InvTabEquipos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (invTabEquipo == null)
            {
                return NotFound();
            }

            return View(invTabEquipo);
        }

        public IActionResult Create()
        {
            return View();
        }


        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NombreEquipo,TipoEquipo,Marca,UbicacionEquipo,Modelo,NoSerie,DireccionMac,So,DatosAdicionales,Procesador,Hdd,Ram,Estatus,FechaCompra,FechaInicioGarantia,FechaFinGarantia,FechaCreacion,UltimaActualizacion,Activo,IdUsuarioRegistro")] InvTabEquipo invTabEquipo)
        {
            if (ModelState.IsValid)
            {
                string autoName;
                autoName = invTabEquipo.UbicacionEquipo;
                invTabEquipo.NombreEquipo = autoName;
                invTabEquipo.UltimaActualizacion = DateTime.Now;
                invTabEquipo.FechaCreacion = DateTime.Now;
                //Se queda pendiente el campo para agregar el id de usuario que registró el equipo
                _context.Add(invTabEquipo);
                await _context.SaveChangesAsync();
                int lastId = invTabEquipo.Id;
                
                if (lastId > 0) 
                {
                    autoName = autoName + "-" + lastId.ToString();
                    invTabEquipo.NombreEquipo = Regex.Replace(autoName, @"\s", "");
                    _context.Update(invTabEquipo);
                    _context.SaveChanges();
                    _context.Database.CloseConnection();
                }

                return RedirectToAction(nameof(Index));
            }
            return View(invTabEquipo);
        }

        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invTabEquipo = await _context.InvTabEquipos.FindAsync(id);
            if (invTabEquipo == null)
            {
                return NotFound();
            }
            return View(invTabEquipo);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NombreEquipo,TipoEquipo,Marca,UbicacionEquipo,Modelo,NoSerie,DireccionMac,So,DatosAdicionales,Procesador,Hdd,Ram,Estatus,FechaCompra,FechaInicioGarantia,FechaFinGarantia,FechaCreacion,UltimaActualizacion,Activo,IdUsuarioRegistro")] InvTabEquipo invTabEquipo)
        {
            if (id != invTabEquipo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    invTabEquipo.UltimaActualizacion = DateTime.Now;
                    _context.Update(invTabEquipo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InvTabEquipoExists(invTabEquipo.Id))
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
            return View(invTabEquipo);
        }

        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invTabEquipo = await _context.InvTabEquipos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (invTabEquipo == null)
            {
                return NotFound();
            }

            return View(invTabEquipo);
        }

        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var invTabEquipo = await _context.InvTabEquipos.FindAsync(id);
            _context.InvTabEquipos.Remove(invTabEquipo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [Authorize]
        private bool InvTabEquipoExists(int id)
        {
            return _context.InvTabEquipos.Any(e => e.Id == id);
        }
    }
}
