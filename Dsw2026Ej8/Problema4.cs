using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema4
    {
        public static double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            double suma = 0;
            int notasValidas = 0;

            if (nota1 != null && nota1 >= 0 && nota1 <= 10)
            {
                suma += (double)nota1;
                notasValidas++;
            }

            if (nota2 != null && nota2 >= 0 && nota2 <= 10)
            {
                suma += (double)nota2;
                notasValidas++;
            }

            if (nota3 != null && nota3 >= 0 && nota3 <= 10)
            {
                suma += (double)nota3;
                notasValidas++;
            }
            if (notasValidas == 0) { return 0; }

            return suma / notasValidas;
        }

    }
}
