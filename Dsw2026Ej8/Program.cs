namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string etiqueta = ProductHelper.ObtenerEtiquetaProducto(77881, "camisa", 10000);
            Console.WriteLine(etiqueta);
            string resumen = ProductHelper.CrearResumenVenta(97612, "pantalón", 3, 15000);
            Console.WriteLine(resumen);

            Product p = new Product("Original");
            string comparacion = ProductHelper.CompararCopias(12, p);
            Console.WriteLine(comparacion);
        }
    }
}
