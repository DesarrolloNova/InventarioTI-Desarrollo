using System;

namespace InventarioTI.Tools
{
    public class ValidateCoockie
    {
        public int GetCoockieValue(string coockie)
        {
            int id = 0;
            //coockie = "vyfCYlDsOzEPAN0kf2vtAQ=="; //Comentar para producción

            Encrypt encrypt = new Encrypt();
            string key = "N0v4Pr1Nt3nCR1pT";
            id = Convert.ToInt32(encrypt.Decrypt(coockie, key));

            return id;
        }
    }
}
