using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public static class Extensions
    {
        public static string ToProductCode(this string text)
        {
            if (string.IsNullOrWhiteSpace(text)){ return "SIN-CODIGO"; }

            return text.Trim().ToUpper() .Replace(" ", "-"); 
        }
    }
}
