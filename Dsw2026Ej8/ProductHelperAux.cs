using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Dsw2026Ej8
{
    public static partial class ProductHelper
    {
        private static string FormatearPrecio(decimal price)
        {
            return price.ToString("C", CultureInfo.CurrentCulture);
        }
    }
}
