using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public static partial class ProductHelper
    {
        public static string ObtenerEtiquetaProducto(long code, string description, decimal price)
        {
            string precioFormateado = FormatearPrecio(price);

            return $"[{code}] {description} - {precioFormateado}";
        }

        public static string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            decimal total = quantity <= 0 ? 0 : quantity * unitPrice;

            var prod = new { Code = productCode, Description = productDescription, Quantity = quantity, Total = total }; //clase anonima
            return $"{prod.Code} - {prod.Description} - {prod.Total:C2}";
        }

        public static string CompararCopias(int originalValue, Product product)
        {
            int localValue = originalValue;
            localValue++;

            Product prod = product;
            prod.CambiarDescripcion("descripción nueva");

            return $"{originalValue}-{localValue}-{prod.Description}";
        }

        public static double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            double suma = 0;
            int notasValidas = 0;

            if(nota1 != null && nota1 >= 0 && nota1 <= 10)
            {
                suma += (double)nota1;
                notasValidas++;
            }

            if(nota2 != null && nota2 >= 0 && nota2 <= 10)
            {
                suma += (double)nota2;
                notasValidas++;
            }

            if(nota3 != null && nota3 >= 0 && nota3 <= 10)
            {
                suma += (double)nota3;
                notasValidas++;
            }
            if(notasValidas == 0) { return 0; }

            return suma / notasValidas;
        }
    }
}
