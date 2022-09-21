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

        public IActionResult Asignacion(int Id)
        {
            var asignacion = _context.InvHisAsignacionEquipos.Where(a => a.IdEquipo == Id && a.Activo == true).FirstOrDefault();

            if (asignacion != null)
            { 
                
            }
            InvHisAsignacionEquipo asignacionEquipo = new InvHisAsignacionEquipo();
            asignacionEquipo.IdEquipo = Id;
            return View(asignacionEquipo);
        }

        [HttpPost]
        public async Task<IActionResult> Asignacion([Bind("Id,FechaInicio,FechaFin,EnDominio,TipoConexion,Ip,IdEquipo,IdDepartamento,Activo,SelectedIds")] InvHisAsignacionEquipo asignacionEquipo)
        {
            if (ModelState.IsValid && asignacionEquipo.SelectedIds != null)
            {
                try
                {
                    InventarioContext contexto = new InventarioContext();
                    asignacionEquipo.Id = 0;
                    asignacionEquipo.FechaInicio = DateTime.Now;
                    contexto.InvHisAsignacionEquipos.Add(asignacionEquipo);
                    await contexto.SaveChangesAsync();
                    contexto.Database.CloseConnection();
                    foreach (var usuario in asignacionEquipo.SelectedIds)
                    {
                        UsuarioAsignacion usuarioAsignacion = new UsuarioAsignacion();
                        usuarioAsignacion.IdUsuario = usuario;
                        usuarioAsignacion.IdAsignacion = asignacionEquipo.Id;
                        usuarioAsignacion.FechaInicioAsignacion = DateTime.Now;
                        usuarioAsignacion.Asignado = true;
                        contexto.UsuarioAsignacion.Add(usuarioAsignacion);
                        await contexto.SaveChangesAsync();
                        contexto.Database.CloseConnection();
                    }
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return View(asignacionEquipo);
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.InvTabEquipos.ToListAsync());
        }

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

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var invTabEquipo = await _context.InvTabEquipos.FindAsync(id);
            _context.InvTabEquipos.Remove(invTabEquipo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InvTabEquipoExists(int id)
        {
            return _context.InvTabEquipos.Any(e => e.Id == id);
        }
    }
}
