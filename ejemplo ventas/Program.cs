using System;

namespace ejemplo_ventas // Reemplaza "MiProyecto" por el nombre exacto de tu proyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Articulo[] articulos = new Articulo[10];

            for (int i = 0; i < 10; i++)
            {
                articulos[i] = new Articulo();
                Console.WriteLine("ingrese los datos del producto...");
                Console.WriteLine("Codigo:");
                articulos[i].CodigoArticulo = int.Parse(Console.ReadLine()!);
                Console.WriteLine("Precio:");
                articulos[i].Precio = float.Parse(Console.ReadLine()!);
                Console.WriteLine("Marca 1 al 10:");
                articulos[i].CodigoMarca = int.Parse(Console.ReadLine()!);
            }
            Console.ReadKey();
        }
    }
}



