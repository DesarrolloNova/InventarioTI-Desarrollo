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
using Microsoft.CodeAnalysis;
using System.Diagnostics;
using InventarioTI.Models.EXT_WEB;
using Newtonsoft.Json;
using InventarioTI.Tools;
using Microsoft.AspNetCore.Hosting.Server;

namespace InventarioTI.Controllers
{
    public class InvTabEquipoesController : Controller
    {
        private readonly InventarioContext _context;
        private readonly CONEXION_EXT_WEB conn = new CONEXION_EXT_WEB();

        public InvTabEquipoesController(InventarioContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Instalacion()
        {
            InvHisPlantillaInstalacion instalacion = new InvHisPlantillaInstalacion();
            return PartialView("_InstalacionModelPartial", instalacion);
        }

        [HttpPost]
        public IActionResult Instalacion(InvHisPlantillaInstalacion instalacion, DateTime initialDate, DateTime finalDate, int idEquipo)
        {
            //Se crea primero la accion
            return RedirectToAction("Details", "InvTabEquipoes", new { id = idEquipo });
        }


        [HttpGet]
        public IActionResult Mantenimiento(int idEquipo)
        {
            InvHisPlantillaMantenimiento mantenimiento = new InvHisPlantillaMantenimiento();
            mantenimiento.IdEquipo = idEquipo;
            return PartialView("_MantenimientoModelPartial", mantenimiento);
        }


        [HttpPost]
        public async Task<IActionResult> Mantenimiento(InvHisPlantillaMantenimiento mantenimiento)
        {
            if (mantenimiento.initialDate == DateTime.Parse("01/01/0001 12:00:00 a. m.") || mantenimiento.finalDate == DateTime.Parse("01/01/0001 12:00:00 a. m."))
            {
                return RedirectToAction("Details", "InvTabEquipoes", new { id = mantenimiento.IdEquipo });
            }
            InventarioContext context = new InventarioContext();
            #region ObtenerUsuarioLogueado
            //
            string coockie;

            //Request.Cookies.TryGetValue("us3r4ct1v3",out coockie); // Descomentar para produccion
            coockie = "vyfCYlDsOzEPAN0kf2vtAQ=="; //Comentar para producción

            Encrypt encrypt = new Encrypt();
            string key = "N0v4Pr1Nt3nCR1pT";
            string id = encrypt.Decrypt(coockie, key);
            //
            #endregion
            #region Llenado Y Guardado De Accion

            InvHisAccionEquipo accionEquipo = new InvHisAccionEquipo();
            accionEquipo.FechaInicio = mantenimiento.initialDate;
            accionEquipo.FechaFin = mantenimiento.finalDate;
            accionEquipo.TipoProceso = "Mantenimiento";
            accionEquipo.IdAsignacion = await context.InvHisAsignacionEquipos.Where(a => a.IdEquipo == mantenimiento.IdEquipo && a.Activo == true).Select(a => a.Id).FirstOrDefaultAsync();
            accionEquipo.IdEquipo = mantenimiento.IdEquipo;
            accionEquipo.IdUsuarioRegistro = Convert.ToInt32(id);
            //Guardamos la acción
            accionEquipo = await SaveAccion(accionEquipo);
            //Guardamos la acción
            #endregion

            #region Llenado y Guardado de la plantilla de Mantenimiento
            mantenimiento.FechaCreacion = DateTime.Now;
            mantenimiento.IdAccionEquipo = accionEquipo.Id;
            #endregion
            //Guardamos la plantilla de mantenimiento
            mantenimiento = await SaveMantenimiento(mantenimiento);
            //Guardamos la plantilla de mantenimiento


            return RedirectToAction("Details", "InvHisAccionEquipoes", new { id = accionEquipo.Id });
        }

        [HttpPost]
        public async Task<IActionResult> DesarchivarEquipo(int idEquipo)
        {
            try
            {
                InventarioContext context = new InventarioContext();
                InvTabEquipo equipo = new InvTabEquipo();
                equipo = context.InvTabEquipos.Where(e => e.Id == idEquipo).FirstOrDefault();

                #region ActualizarEstatusEquipo
                equipo.IdEstatus = 2; //Estatus disponible
                equipo.UltimaActualizacion = DateTime.Now;
                context.InvTabEquipos.Update(equipo);
                await context.SaveChangesAsync();
                #endregion
                context.Database.CloseConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return RedirectToAction(nameof(VerArchivados));
        }

        [HttpPost]
        public async Task<IActionResult> ArchivarEquipo(string del, int idEquipo)
        {

            try
            {
                InventarioContext context = new InventarioContext();
                if (del == "Si")
                {
                    #region GetAsignacionEquipo
                    InvHisAsignacionEquipo asignacionEquipo = new InvHisAsignacionEquipo();
                    asignacionEquipo = context.InvHisAsignacionEquipos.Where(a => a.IdEquipo == idEquipo).FirstOrDefault();
                    #endregion
                    #region FinalizarAsignación
                    if (asignacionEquipo != null && asignacionEquipo.Id != 0)
                    {
                        InvHisAsignacionEquipoesController equipoesController = new InvHisAsignacionEquipoesController(context);
                        await equipoesController.FinalizarAsignacion(asignacionEquipo.Id, idEquipo);
                    }
                    #endregion
                    #region ActualizarEquipo
                    InvTabEquipo equipo = new InvTabEquipo();
                    equipo = context.InvTabEquipos.Where(e => e.Id == idEquipo).FirstOrDefault();
                    equipo.IdEstatus = 6; //IdArchivado de InvCatEstatus
                    equipo.UltimaActualizacion = DateTime.Now;
                    context.InvTabEquipos.Update(equipo);
                    await context.SaveChangesAsync();
                    #endregion
                    context.Database.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return RedirectToAction("Index", "InvTabEquipoes");
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
        public async Task<IActionResult> Asignacion([Bind("Id,FechaInicio,FechaFin,EnDominio,TipoConexion,Ip,IdEquipo,IdDepartamento,Activo,IDSitio,ID_Area")] InvHisAsignacionEquipo asignacionEquipo)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    InventarioContext contexto = new InventarioContext();
                    asignacionEquipo.Id = 0;
                    asignacionEquipo.FechaInicio = DateTime.Now;
                    asignacionEquipo.Activo = true;

                    contexto.InvHisAsignacionEquipos.Add(asignacionEquipo);
                    await contexto.SaveChangesAsync();
                    contexto.Database.CloseConnection();
                    //foreach (var usuario in asignacionEquipo.SelectedIds)
                    //{
                    //    UsuarioAsignacion usuarioAsignacion = new UsuarioAsignacion();
                    //    usuarioAsignacion.IdUsuario = usuario;
                    //    usuarioAsignacion.IdAsignacion = asignacionEquipo.Id;
                    //    usuarioAsignacion.FechaInicioAsignacion = DateTime.Now;
                    //    usuarioAsignacion.Asignado = true;
                    //    contexto.UsuarioAsignacion.Add(usuarioAsignacion);
                    //    await contexto.SaveChangesAsync();
                    //    contexto.Database.CloseConnection();
                    //}
                    InvTabEquipo equipo = new InvTabEquipo();
                    equipo = contexto.InvTabEquipos.Where(e => e.Id == asignacionEquipo.IdEquipo).FirstOrDefault();
                    equipo.IdEstatus = 4;// "ASIGNADO";
                    contexto.InvTabEquipos.Update(equipo);
                    await contexto.SaveChangesAsync();
                    contexto.Database.CloseConnection();
                    return RedirectToAction("Details", "InvHisAsignacionEquipoes", new { id = asignacionEquipo.Id });
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
            return View(await _context.InvTabEquipos.Where(e => e.IdEstatus != 6).ToListAsync());
        }


        public async Task<IActionResult> VerArchivados()
        {
            return View(await _context.InvTabEquipos.Where(e => e.IdEstatus == 6).ToListAsync());
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
        public async Task<IActionResult> Create([Bind("Id,NombreEquipo,TipoEquipo,Marca,Modelo,NoSerie,DireccionMac,So,DatosAdicionales,Procesador,Hdd,Ram,Estatus,FechaCompra,FechaInicioGarantia,FechaFinGarantia,FechaCreacion,UltimaActualizacion,IdUsuarioRegistro,IDSitio")] InvTabEquipo invTabEquipo)
        {
            if (ModelState.IsValid)
            {
                InventarioContext context = new InventarioContext();
                string autoName;
                List<RHCF10_Plantas> catPlants = new List<RHCF10_Plantas>();
                string json = await conn.GetQueryResult("SELECT * FROM RHCF10 WHERE IDSitio=" + invTabEquipo.IDSitio);
                try
                {
                    catPlants = JsonConvert.DeserializeObject<List<RHCF10_Plantas>>(json);
                    autoName = catPlants.FirstOrDefault().Nombre;
                }
                catch (Exception ex)
                {
                    autoName = "";
                    Console.WriteLine(ex.Message);
                }
                invTabEquipo.NombreEquipo = autoName;
                invTabEquipo.UltimaActualizacion = DateTime.Now;
                invTabEquipo.FechaCreacion = DateTime.Now;
                invTabEquipo.IdEstatus = 2; //Estatus Disponible

                //
                string coockie;

                //Request.Cookies.TryGetValue("us3r4ct1v3",out coockie); // Descomentar para produccion
                coockie = "vyfCYlDsOzEPAN0kf2vtAQ=="; //Comentar para producción

                Encrypt encrypt = new Encrypt();
                string key = "N0v4Pr1Nt3nCR1pT";
                string id = encrypt.Decrypt(coockie, key);
                //
                invTabEquipo.IdUsuarioRegistro = Convert.ToInt32(id);
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
        public async Task<IActionResult> Edit(int id, [Bind("Id,NombreEquipo,TipoEquipo,Marca,IDSitio,Modelo,NoSerie,DireccionMac,So,DatosAdicionales,Procesador,Hdd,Ram,IdEstatus,FechaCompra,FechaInicioGarantia,FechaFinGarantia,FechaCreacion,UltimaActualizacion,IdUsuarioRegistro")] InvTabEquipo invTabEquipo)
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
                return RedirectToAction("Details", "InvTabEquipoes", new { id = id });
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

        #region Private Methods
        private async Task<InvHisAccionEquipo> SaveAccion(InvHisAccionEquipo accionEquipo)
        {
            bool aux = false;
            InventarioContext context = new InventarioContext();
            if (aux == false)
            {
                aux = true;
                context.InvHisAccionEquipos.Add(accionEquipo);
            }
            await context.SaveChangesAsync();
            return accionEquipo;
        }

        private async Task<InvHisPlantillaMantenimiento> SaveMantenimiento(InvHisPlantillaMantenimiento mantenimiento)
        {
            bool aux = false;
            InventarioContext context = new InventarioContext();
            if (aux == false)
            {
                aux = true;
                context.InvHisPlantillaMantenimientos.Add(mantenimiento);
            }
            await context.SaveChangesAsync();
            return mantenimiento;
        }

        private async Task<InvHisPlantillaInstalacion> SaveInstalacion(InvHisPlantillaInstalacion instalacion)
        {
            bool aux = false;
            InventarioContext context = new InventarioContext();
            if (aux == false)
            {
                aux = true;
                context.InvHisPlantillaInstalacions.Add(instalacion);
            }
            await context.SaveChangesAsync();
            return instalacion;
        }
        #endregion
    }
}
