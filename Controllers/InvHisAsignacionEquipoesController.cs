using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InventarioTI.Context;
using InventarioTI.Models;
using Microsoft.AspNetCore.Authorization;
using InventarioTI.Tools;

namespace InventarioTI.Controllers
{
    public class InvHisAsignacionEquipoesController : Controller
    {
        private readonly InventarioContext _context;
        ValidateCoockie validateCoockie = new ValidateCoockie();
        public InvHisAsignacionEquipoesController(InventarioContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> AgregarUsuarios(List<int> SelectedIds, int idAsignacion)
        {
            bool isCoockie = Request.Cookies.ContainsKey("us3r4ct1v3");
            isCoockie = validateCoockie.GetCoockieExist(isCoockie);
            if (isCoockie != false)
            {
                try
                {
                    InventarioContext context = new InventarioContext();
                    foreach (var userId in SelectedIds)
                    {
                        #region LlenadoDeObjeto
                        UsuarioAsignacion usuarioAsignacion = new UsuarioAsignacion();
                        usuarioAsignacion.idEmpleado = userId;
                        usuarioAsignacion.idAsignacion = idAsignacion;
                        usuarioAsignacion.fechaInicioAsignacion = DateTime.Now;
                        usuarioAsignacion.asignado = true;
                        #endregion
                        #region MetodoAddUsuarioAsignacion
                        context.UsuarioAsignacion.Add(usuarioAsignacion);
                        await context.SaveChangesAsync();
                        context.Database.CloseConnection();
                        #endregion
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return RedirectToAction("Details", "InvHisAsignacionEquipoes", new { id = idAsignacion });
            }
            else
            {
                return RedirectToAction("UserNotFound", "Home");
            }
        }

        [HttpPost]
        public async Task<IActionResult> FinalizarAsignacion(int idAsignacion, int idEquipo)
        {
            InvTabEquipo equipo = new InvTabEquipo();
            InventarioContext context = new InventarioContext();
            InvHisAsignacionEquipo asignacion = new InvHisAsignacionEquipo();
            //
            List<int> idUsuarios = new List<int>();
            List<TabUsuario> usuarios = new List<TabUsuario>();

            idUsuarios = context.UsuarioAsignacion.Where(u => u.idAsignacion == idAsignacion && u.asignado == true).Select(u => u.idEmpleado).ToList();
            foreach (var idusuario in idUsuarios)
            {
                UsuarioAsignacion usuarioAsignacion = new UsuarioAsignacion();
                usuarioAsignacion = context.UsuarioAsignacion.Where(ua => ua.idEmpleado == idusuario && ua.idAsignacion == idAsignacion).FirstOrDefault();
                usuarioAsignacion.asignado = false;
                usuarioAsignacion.fechaFinAsignacion = DateTime.Now;
                #region ActualizarAsignacionIndividual
                context.UsuarioAsignacion.Update(usuarioAsignacion);
                await context.SaveChangesAsync();
                context.Database.CloseConnection();
                #endregion
            }
            //
            #region ExtractInfo
            asignacion = context.InvHisAsignacionEquipos.Where(a => a.Id == idAsignacion).FirstOrDefault();
            equipo = context.InvTabEquipos.Where(e => e.Id == idEquipo).FirstOrDefault();
            #endregion
            //ACTUALIZACION DE ESTATUS
            asignacion.Activo = false;
            asignacion.FechaFin = DateTime.Now;
            equipo.IdEstatus = 2; //ESTATUS DISPONIBLE
                                  //ACTUALIZACION DE ESTATUS
            /*ACTUALIZACIÓN*/
            #region ActualizarEquipo
            context.InvTabEquipos.Update(equipo);
            await context.SaveChangesAsync();
            context.Database.CloseConnection();
            #endregion
            /*ACTUALIZACIÓN*/
            #region ActualizarAsignacion
            context.InvHisAsignacionEquipos.Update(asignacion);
            await context.SaveChangesAsync();
            context.Database.CloseConnection();
            #endregion
            /*ACTUALIZACIÓN*/
            return RedirectToAction("Details", "InvTabEquipoes", new { id = idEquipo });
        }

        [HttpPost]
        public async Task<IActionResult> FinalizarAsignacionIndividual(int idUsuario, int idAsignacion)
        {
            bool isCoockie = Request.Cookies.ContainsKey("us3r4ct1v3");
            isCoockie = validateCoockie.GetCoockieExist(isCoockie);
            if (isCoockie != false)
            {
                InventarioContext context = new InventarioContext();
                UsuarioAsignacion usuarioAsignacion = new UsuarioAsignacion();
                usuarioAsignacion = context.UsuarioAsignacion.Where(ua => ua.idEmpleado == idUsuario && ua.idAsignacion == idAsignacion).FirstOrDefault();
                usuarioAsignacion.asignado = false;
                usuarioAsignacion.fechaFinAsignacion = DateTime.Now;
                context.UsuarioAsignacion.Update(usuarioAsignacion);
                await context.SaveChangesAsync();
                context.Database.CloseConnection();
                return RedirectToAction("Details", new { id = idAsignacion });
            }
            else
            {
                return RedirectToAction("UserNotFound", "Home");
            }
        }

        public async Task<IActionResult> Index(int idEquipo)
        {
            bool isCoockie = Request.Cookies.ContainsKey("us3r4ct1v3");
            isCoockie = validateCoockie.GetCoockieExist(isCoockie);
            if (isCoockie != false)
            {
                var inventarioContext = _context.InvHisAsignacionEquipos.Where(i => i.IdEquipo == idEquipo && i.Activo == false);
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

                var invHisAsignacionEquipo = await _context.InvHisAsignacionEquipos
                    .Include(i => i.IdEquipoNavigation)
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (invHisAsignacionEquipo == null)
                {
                    return NotFound();
                }

                return View(invHisAsignacionEquipo);
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
                ViewData["IdEquipo"] = new SelectList(_context.InvTabEquipos, "Id", "DireccionMac");
                return View();
            }
            else
            {
                return RedirectToAction("UserNotFound", "Home");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FechaInicio,FechaFin,EnDominio,TipoConexion,Ip,IdEquipo,IdDepartamento,Activo")] InvHisAsignacionEquipo invHisAsignacionEquipo)
        {
            bool isCoockie = Request.Cookies.ContainsKey("us3r4ct1v3");
            isCoockie = validateCoockie.GetCoockieExist(isCoockie);
            if (isCoockie != false)
            {
                if (ModelState.IsValid)
                {
                    _context.Add(invHisAsignacionEquipo);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                ViewData["IdEquipo"] = new SelectList(_context.InvTabEquipos, "Id", "DireccionMac", invHisAsignacionEquipo.IdEquipo);
                return View(invHisAsignacionEquipo);
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

                var invHisAsignacionEquipo = await _context.InvHisAsignacionEquipos.FindAsync(id);
                if (invHisAsignacionEquipo == null)
                {
                    return NotFound();
                }
                ViewData["IdEquipo"] = new SelectList(_context.InvTabEquipos, "Id", "DireccionMac", invHisAsignacionEquipo.IdEquipo);
                return View(invHisAsignacionEquipo);
            }
            else
            {
                return RedirectToAction("UserNotFound", "Home");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FechaInicio,FechaFin,EnDominio,TipoConexion,Ip,IdEquipo,IdDepartamento,Activo")] InvHisAsignacionEquipo invHisAsignacionEquipo)
        {
            bool isCoockie = Request.Cookies.ContainsKey("us3r4ct1v3");
            isCoockie = validateCoockie.GetCoockieExist(isCoockie);
            if (isCoockie != false)
            {
                if (id != invHisAsignacionEquipo.Id)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(invHisAsignacionEquipo);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!InvHisAsignacionEquipoExists(invHisAsignacionEquipo.Id))
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
                ViewData["IdEquipo"] = new SelectList(_context.InvTabEquipos, "Id", "DireccionMac", invHisAsignacionEquipo.IdEquipo);
                return View(invHisAsignacionEquipo);
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

                var invHisAsignacionEquipo = await _context.InvHisAsignacionEquipos
                    .Include(i => i.IdEquipoNavigation)
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (invHisAsignacionEquipo == null)
                {
                    return NotFound();
                }

                return View(invHisAsignacionEquipo);
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
                var invHisAsignacionEquipo = await _context.InvHisAsignacionEquipos.FindAsync(id);
                _context.InvHisAsignacionEquipos.Remove(invHisAsignacionEquipo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return RedirectToAction("UserNotFound", "Home");
            }
        }

        private bool InvHisAsignacionEquipoExists(int id)
        {
            return _context.InvHisAsignacionEquipos.Any(e => e.Id == id);
        }
    }
}
