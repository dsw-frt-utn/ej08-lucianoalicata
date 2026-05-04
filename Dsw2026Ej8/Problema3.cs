using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Dsw2026Ej8
{
    internal class Problema3
    {
        public static string CompararCopias(int originalValue, Product product)
        {
            int localValue = originalValue;
            localValue++;

            Product prod = product;
            prod.CambiarDescripcion("descripción nueva");

            return $"{originalValue}-{localValue}-{prod.Description}";
        }

    }
}
