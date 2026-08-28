using System.Linq;

namespace Ejercicios2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> listaAnimales = new List<Animal>();

            listaAnimales.Add(new Gato("JOJO", 3, true));
            listaAnimales.Add(new Perro("Rocco", 2, "Mestizo"));

            // --- 5 GATOS ADICIONALES ---
            // Formato: Gato(nombre, edad, esCasero/tieneVacunas)
            listaAnimales.Add(new Gato("Michi", 1, false));
            listaAnimales.Add(new Gato("Luna", 5, true));
            listaAnimales.Add(new Gato("Garfield", 7, true));
            listaAnimales.Add(new Gato("Simba", 2, false));
            listaAnimales.Add(new Gato("Cleo", 4, true));

            // --- 5 PERROS ADICIONALES ---
            // Formato: Perro(nombre, edad, raza)
            listaAnimales.Add(new Perro("Lola", 4, "Labrador"));
            listaAnimales.Add(new Perro("Toby", 1, "Caniche"));
            listaAnimales.Add(new Perro("Thor", 6, "Ovejero Alemán"));
            listaAnimales.Add(new Perro("Bimba", 3, "Bulldog"));
            listaAnimales.Add(new Perro("Milo", 5, "Golden Retriever"));
            /*
            foreach (var item in listaAnimales)
            {
                item.describir();
            }

            foreach (var item in listaAnimales.ToList())
            {
                if (item.edadPublic < 2)
                {
                    listaAnimales.Remove(item);
                }
            }
            Console.WriteLine("Post borrar edad <2 \n");
             */

            var animalesFiltro = listaAnimales.Where(animal => animal.edadPublic > 3);


            foreach (var item in animalesFiltro)
            {
                item.describir();
            }


            Console.ReadKey();
        }
    }
}
