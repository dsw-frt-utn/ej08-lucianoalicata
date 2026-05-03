namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string etiqueta = ProductHelper.ObtenerEtiquetaProducto(77881, "camisa", 10000);
            Console.WriteLine(etiqueta);
        }
    }
}
