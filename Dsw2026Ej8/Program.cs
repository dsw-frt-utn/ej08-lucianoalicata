
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
            string resumen = Problema2.CrearResumenVenta(97612, "pantalón", 3, 15000);
            Console.WriteLine(resumen);

        }
    }
}
