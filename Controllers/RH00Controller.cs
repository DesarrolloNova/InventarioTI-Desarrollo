using DocumentFormat.OpenXml.Office2010.ExcelAc;
using DocumentFormat.OpenXml.Office2021.DocumentTasks;
using InventarioTI.Context;
using InventarioTI.Models;
using InventarioTI.Models.EXT_WEB;
using InventarioTI.Tools;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventarioTI.Controllers
{
    public class RH00Controller : Controller
    {
        CONEXION_EXT_WEB conn = new CONEXION_EXT_WEB();
        InventarioContext context = new InventarioContext();
        ValidateCoockie validateCoockie = new ValidateCoockie();
        public async Task<IActionResult> Index()
        {
            bool isCoockie = Request.Cookies.ContainsKey("us3r4ct1v3");
            isCoockie = validateCoockie.GetCoockieExist(isCoockie);
            if (isCoockie != false)
            {
                List<RH00_Usuarios> usuarios = new List<RH00_Usuarios>();
                string json = await conn.GetQueryResult("SELECT * FROM RH00 WHERE IdEmpleado IN (SELECT IdEmpleado FROM RH03 WHERE Activo = 1)");
                usuarios = JsonConvert.DeserializeObject<List<RH00_Usuarios>>(json);

                return View(usuarios);
            }
            else
            {
                return RedirectToAction("UserNotFound", "Home");
            }
        }

        [HttpPost]
        public IActionResult VerEquiposPorEmpleado(int idEmpleado)
        {
            bool isCoockie = Request.Cookies.ContainsKey("us3r4ct1v3");
            isCoockie = validateCoockie.GetCoockieExist(isCoockie);
            if (isCoockie != false)
            {
                List<InvTabEquipo> equipos = new List<InvTabEquipo>();
                equipos = context.InvTabEquipos.Where(e => e.Id == context.InvHisAsignacionEquipos.Where(a => a.Activo == true && a.Id == context.UsuarioAsignacion.Where(ua => ua.idEmpleado == idEmpleado).Select(ua => ua.idAsignacion).FirstOrDefault()).Select(a => a.IdEquipo).FirstOrDefault()).ToList();


                return View(equipos);
            }
            else
            {
                return RedirectToAction("UserNotFound", "Home");
            }

        }

        [HttpPost]
        public IActionResult VerLicenciasPorEmpleado(int idEmpleado)
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
    }
}
