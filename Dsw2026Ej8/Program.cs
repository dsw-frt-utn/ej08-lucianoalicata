using static Dsw2026Ej8.Sale;

namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            string etiqueta = ProductHelper.ObtenerEtiquetaProducto(77881, "camisa", 10000);
            Console.WriteLine(etiqueta);
            //2
            string resumen = ProductHelper.CrearResumenVenta(97612, "pantalón", 3, 15000);
            Console.WriteLine(resumen);
            //3
            Product p = new Product("Original");
            string comparacion = ProductHelper.CompararCopias(12, p);
            Console.WriteLine(comparacion);
            //4
            double promedio = ProductHelper.CalcularPromedio(8, null, 7);
            Console.WriteLine(promedio);
            //5
            Sale minorista = new RetailSale {Amount = 1000};
            decimal totalRetail = ProductHelper.ObtenerImporteFinal(minorista);
            Console.WriteLine($"total minorista: {totalRetail}");
            Sale mayorista = new WholesaleSale {Amount = 1000};
            decimal totalWholesale = ProductHelper.ObtenerImporteFinal(mayorista);
            Console.WriteLine($"total mayorista: {totalWholesale}");

            //6
            string sinFormato = "  ab 123 x  ";
            string conFormato = ProductHelper.NormalizarCodigoProducto(sinFormato);
            Console.WriteLine($"sin formato: '{sinFormato}'");
            Console.WriteLine($"con formato: {conFormato}"); 

            string codigoNulo = null;
            Console.WriteLine($"nulo: {ProductHelper.NormalizarCodigoProducto(codigoNulo)}");

        }
    }
}
