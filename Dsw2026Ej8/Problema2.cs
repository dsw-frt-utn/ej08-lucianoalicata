using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema2
    {
        public static string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            decimal total = quantity <= 0 ? 0 : quantity * unitPrice;

            var prod = new { Code = productCode, Description = productDescription, Quantity = quantity, Total = total }; //clase anonima
            return $"{prod.Code} - {prod.Description} - {prod.Total:C2}";
        }
    }
}
