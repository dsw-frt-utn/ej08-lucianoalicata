using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Product
    {
        public string Description;

        public Product(string description)
        {
            Description = description;
        }

        public void CambiarDescripcion(string nuevaDescripcion)
        {
            Description = nuevaDescripcion;
        }
    }
}
