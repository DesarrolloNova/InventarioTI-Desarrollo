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

        [HttpPost]
        public async Task<IActionResult> FinalizarAsignacion(int idAsignacion, int idLicencia)
        {
            Licencias licencia = new Licencias();
            InventarioContext context = new InventarioContext();
            InvHisAsignacionLicencia asignacionLicencia = new InvHisAsignacionLicencia();
            //
            List<int> idUsuarios = new List<int>();
            List<TabUsuario> usuarios = new List<TabUsuario>();

            idUsuarios = context.UsuarioLicencias.Where(u => u.IdAsignacion == idAsignacion && u.Asignado == true).Select(u => u.IdEmpleado).ToList();
            foreach (var idusuario in idUsuarios)
            {
                UsuarioLicencias usuarioLicencias = new UsuarioLicencias();
                usuarioLicencias = context.UsuarioLicencias.Where(ua => ua.IdEmpleado == idusuario && ua.IdAsignacion == idAsignacion).FirstOrDefault();
                usuarioLicencias.Asignado = false;
                usuarioLicencias.FechaFinAsignacion = DateTime.Now;
                #region ActualizarAsignacionIndividual
                context.UsuarioLicencias.Update(usuarioLicencias);
                await context.SaveChangesAsync();
                context.Database.CloseConnection();
                #endregion
            }
            //
            #region ExtractInfo
            asignacionLicencia = context.InvHisAsignacionLicencia.Where(a => a.Id == idAsignacion).FirstOrDefault();
            licencia = context.Licencias.Where(e => e.Id == idLicencia).FirstOrDefault();
            #endregion
            //ACTUALIZACION DE ESTATUS
            asignacionLicencia.Activo = false;
            asignacionLicencia.FechaFin = DateTime.Now;
            //ACTUALIZACION DE ESTATUS
            /*ACTUALIZACIÓN*/
            //#region ActualizarEquipo
            //context.InvTabEquipos.Update(equipo);
            //await context.SaveChangesAsync();
            //context.Database.CloseConnection();
            //#endregion
            /*ACTUALIZACIÓN*/
            #region ActualizarAsignacion
            context.InvHisAsignacionLicencia.Update(asignacionLicencia);
            await context.SaveChangesAsync();
            context.Database.CloseConnection();
            #endregion
            /*ACTUALIZACIÓN*/
            return RedirectToAction("Details", "Licencias", new { id = idLicencia });
        }

        [HttpPost]
        public async Task<IActionResult> FinalizarAsignacionIndividual(int idUsuario, int idAsignacion)
        {
            bool isCoockie = Request.Cookies.ContainsKey("us3r4ct1v3");
            isCoockie = validateCoockie.GetCoockieExist(isCoockie);
            if (isCoockie != false)
            {
                InventarioContext context = new InventarioContext();
                UsuarioLicencias usuarioLicencia = new UsuarioLicencias();
                usuarioLicencia = context.UsuarioLicencias.Where(ua => ua.IdEmpleado == idUsuario && ua.IdAsignacion == idAsignacion).FirstOrDefault();
                usuarioLicencia.Asignado = false;
                usuarioLicencia.FechaFinAsignacion = DateTime.Now;
                context.UsuarioLicencias.Update(usuarioLicencia);
                await context.SaveChangesAsync();
                context.Database.CloseConnection();
                return RedirectToAction("Details", new { id = idAsignacion });
            }
            else
            {
                return RedirectToAction("UserNotFound", "Home");
            }
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
                        UsuarioLicencias usuarioLicencia = new UsuarioLicencias();
                        usuarioLicencia.IdEmpleado = userId;
                        usuarioLicencia.IdAsignacion = idAsignacion;
                        usuarioLicencia.FechaInicioAsignacion = DateTime.Now;
                        usuarioLicencia.Asignado = true;
                        #endregion
                        #region MetodoAddUsuarioAsignacion
                        context.UsuarioLicencias.Add(usuarioLicencia);
                        await context.SaveChangesAsync();
                        context.Database.CloseConnection();
                        #endregion
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return RedirectToAction("Details", "InvHisAsignacionLicencias", new { id = idAsignacion });
            }
            else
            {
                return RedirectToAction("UserNotFound", "Home");
            }
        }

        public async Task<IActionResult> Index(int idLicencia)
        {
            bool isCoockie = Request.Cookies.ContainsKey("us3r4ct1v3");
            isCoockie = validateCoockie.GetCoockieExist(isCoockie);
            if (isCoockie != false)
            {
                return View(await _context.InvHisAsignacionLicencia.Where(al=>al.IdLicencia == idLicencia).ToListAsync());
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
        public async Task<IActionResult> Create([Bind("Id,Activo,IDSitio,ID_Area,IdLicencia,InicioVigencia,FinVigencia,Usuario,Clave,CodigoProducto")] InvHisAsignacionLicencia invHisAsignacionLicencia)
        {
            if (ModelState.IsValid)
            {
                invHisAsignacionLicencia.FechaInicio = DateTime.Now;
                invHisAsignacionLicencia.Activo = true;
                _context.Add(invHisAsignacionLicencia);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "InvHisAsignacionLicencias", new { id = invHisAsignacionLicencia.Id });
            }
            return View(invHisAsignacionLicencia);
        }
    }
}
