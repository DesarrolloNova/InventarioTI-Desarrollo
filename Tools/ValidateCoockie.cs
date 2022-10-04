using System;

namespace InventarioTI.Tools
{
    public class ValidateCoockie
    {
        public int GetCoockieValue()
        {
            int id = 0;

            string coockie;

            //Request.Cookies.TryGetValue("us3r4ct1v3",out coockie); // Descomentar para produccion
            coockie = "vyfCYlDsOzEPAN0kf2vtAQ=="; //Comentar para producción

            Encrypt encrypt = new Encrypt();
            string key = "N0v4Pr1Nt3nCR1pT";
            id = Convert.ToInt32(encrypt.Decrypt(coockie, key));

            return id;
        }
    }
}
