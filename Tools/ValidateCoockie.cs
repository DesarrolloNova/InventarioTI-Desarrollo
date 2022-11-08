using ClasesNovaprint.Clases;
using CookiesNovaprintNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.JSInterop;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Threading.Tasks;
using static ClosedXML.Excel.XLPredefinedFormat;



namespace InventarioTI.Tools
{
    public class ValidateCoockie
    {
        NovUsuarioCookie usuario;
        IJSRuntime JS;

        public int GetCoockieValue(string coockie)
        {
            int id = 0;
            coockie = "vyfCYlDsOzEPAN0kf2vtAQ=="; //Comentar para producción
            Encrypt encrypt = new Encrypt();
            string key = "N0v4Pr1Nt3nCR1pT";
            id = Convert.ToInt32(encrypt.Decrypt(coockie, key));

            return id;
        }

        public bool GetCoockieExist(bool isActive)
        {
            isActive = true; //Comentar para producción
            return isActive;
        }

        public async Task<NovUsuarioCookie> ReadCoockie()
        {
            usuario = await CookiesNetCore.ObtenerCookieSesion(JS);
            return usuario;
        }
    }
}
