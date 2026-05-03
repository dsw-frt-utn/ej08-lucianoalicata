using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Sale
    {
        public decimal Amount;
        public virtual decimal CalculateTotal() {  return Amount; }

        public class RetailSale : Sale
        {
            public override decimal CalculateTotal()
            {
                return Amount;
            }
        }
        public class WholesaleSale : Sale
        {
            public override decimal CalculateTotal()
            {
                decimal descuento = Amount * (decimal)0.10;
                return Amount - descuento;
            }
        }
    }
}
