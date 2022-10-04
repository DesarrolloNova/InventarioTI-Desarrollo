using InventarioTI.Context;
using InventarioTI.Models;
using Microsoft.AspNetCore.Mvc;
using QRCoder;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;

namespace InventarioTI.Controllers
{
    public class QRController : Controller
    {
        [HttpPost]
        public IActionResult Index(int IdEquipo)
        {
            try
            {
                InventarioContext context = new InventarioContext();
                QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
                QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode("Esta es la puta url perra", QRCodeGenerator.ECCLevel.Q);
                QRCode qRCode = new QRCode(qRCodeData);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (Bitmap bitmap = new Bitmap(qRCode.GetGraphic(20)))
                    {
                        bitmap.Save(ms, ImageFormat.Png);
                        ViewBag.QRCodeImage = "data:image/png;base64," + Convert.ToBase64String(ms.ToArray());
                    }
                }
                ViewBag.Name = context.InvTabEquipos.Where(e => e.Id == IdEquipo).FirstOrDefault().NombreEquipo;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return View();
        }
    }
}
