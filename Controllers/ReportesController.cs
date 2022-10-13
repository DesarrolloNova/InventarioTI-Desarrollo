using ClosedXML.Excel;
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
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace InventarioTI.Controllers
{
    public class ReportesController : Controller
    {
        InventarioContext context = new InventarioContext();
        CONEXION_EXT_WEB conn = new CONEXION_EXT_WEB();
        public async Task<ActionResult> GenerarReporteEquipos(int slc_report)
        {

            List<InvTabEquipo> equipos = new List<InvTabEquipo>();
            List<RH00_Usuarios> empleados = new List<RH00_Usuarios>();
            string fileName = "";

            switch (slc_report)
            {
                case 1://Solo equipos
                    equipos = context.InvTabEquipos.ToList();
                    fileName = "REPORTE_DE_EQUIPOS_GENERAL.xlsx";
                    break;
                case 2://Los equipos asignados
                    equipos = context.InvTabEquipos.Where(e => e.IdEstatus == 4).ToList();
                    fileName = "REPORTE_DE_EQUIPOS_ASIGNADOS.xlsx";
                    break;
                case 3://Los equipos no asignados
                    equipos = context.InvTabEquipos.Where(e => e.IdEstatus == 2).ToList();
                    fileName = "REPORTE_DE_EQUIPOS_NO_ASIGNADOS.xlsx";
                    break;
                case 4://Los equipos archivados
                    equipos = context.InvTabEquipos.Where(e => e.IdEstatus == 6).ToList();
                    fileName = "REPORTE_DE_EQUIPOS_ARCHIVADOS.xlsx";
                    break;
                default:
                    break;
            }
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Equipos");
                var currentRow = 1;

                //
                int headerIndexEquipos = 1;
                PropertyInfo[] propertiesEquipos = typeof(InvTabEquipo).GetProperties();
                if (slc_report != 2)
                {
                    foreach (PropertyInfo property in propertiesEquipos)
                    {
                        //así obtenemos el nombre del atributo
                        string NombreAtributo = property.Name;
                        #region Header
                        worksheet.Cell(currentRow, headerIndexEquipos).Value = NombreAtributo;
                        headerIndexEquipos++;
                        #endregion
                    }
                }

                for (int i = 0; i < equipos.Count; i++)
                {
                    if (slc_report == 2)
                    {
                        headerIndexEquipos = 1;
                        foreach (PropertyInfo property in propertiesEquipos)
                        {
                            //así obtenemos el nombre del atributo
                            string NombreAtributo = property.Name;
                            #region Header
                            worksheet.Cell(currentRow, headerIndexEquipos).Value = NombreAtributo;
                            headerIndexEquipos++;
                            #endregion
                        }
                    }
                    empleados.Clear();
                    headerIndexEquipos = 1;
                    currentRow++;
                    foreach (var property1 in propertiesEquipos)
                    {
                        string Valor;
                        try
                        {
                            if (property1.GetValue(equipos[i]) == null)
                            {
                                Valor = "";
                            }
                            else
                            {
                                Valor = property1.GetValue(equipos[i]).ToString();
                            }
                        }
                        catch (Exception ex)
                        {
                            Valor = "";
                        }
                        worksheet.Cell(currentRow, headerIndexEquipos).Value = Valor;
                        headerIndexEquipos++;
                    }
                    if (slc_report == 2)
                    {
                        int idAsignacion = context.InvHisAsignacionEquipos.Where(a => a.Activo == true && a.IdEquipo == equipos[i].Id).Select(a => a.Id).FirstOrDefault();
                        int[] empleadosIds;
                        empleadosIds = context.UsuarioAsignacion.Where(ua => ua.idAsignacion == idAsignacion).Select(ua => ua.idEmpleado).ToArray();
                        if (empleadosIds.Length > 0)
                        {
                            #region Header de Empleados
                            headerIndexEquipos = 1;
                            currentRow++;

                            PropertyInfo[] propertiesEmpleados1 = typeof(RH00_Usuarios).GetProperties();
                            foreach (PropertyInfo property in propertiesEmpleados1)
                            {
                                string nombreatributo = property.Name;
                                #region header
                                worksheet.Cell(currentRow, headerIndexEquipos).Value = nombreatributo;
                                headerIndexEquipos++;
                                #endregion
                            }
                            #endregion

                            #region BodyEmpleados
                            int empleadosIndex = 0;
                            foreach (var idEmpleado in empleadosIds)
                            {
                                currentRow++;
                                headerIndexEquipos = 1;
                                RH00_Usuarios empleado = new RH00_Usuarios();
                                string jsonEmpleado = await conn.GetQueryResult("SELECT * FROM RH00 WHERE IdEmpleado = " + idEmpleado.ToString());
                                try
                                {
                                    empleado = JsonConvert.DeserializeObject<List<RH00_Usuarios>>(jsonEmpleado).FirstOrDefault();
                                    empleados.Add(empleado);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                                foreach (var property3 in propertiesEmpleados1)
                                {
                                    string Valor;
                                    try
                                    {
                                        if (property3.GetValue(empleados[empleadosIndex]) == null)
                                        {
                                            Valor = "";
                                        }
                                        else
                                        {
                                            Valor = property3.GetValue(empleados[empleadosIndex]).ToString();
                                        }

                                    }
                                    catch (Exception ex)
                                    {
                                        Valor = "";
                                    }
                                    worksheet.Cell(currentRow, headerIndexEquipos).Value = Valor;
                                    headerIndexEquipos++;
                                }
                                empleadosIndex++;
                            }
                            currentRow++;
                            #endregion
                        }
                        currentRow++;
                    }
                }
                //

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();

                    return File(
                        content,
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        fileName
                        );
                }
            }
        }
    }
}
