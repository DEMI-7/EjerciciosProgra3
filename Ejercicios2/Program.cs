using System.Linq;

namespace Ejercicios2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> listaAnimales = new List<Animal>();
            List<IAtendible> listaAtencion = new List<IAtendible>();

            // LISTA DE CLASES
            // --- GATOS  ---
            listaAnimales.Add(new Gato("JOJO", 3, true));
            listaAnimales.Add(new Gato("Michi", 1, false));
            listaAnimales.Add(new Gato("Luna", 5, true));
            listaAnimales.Add(new Gato("Garfield", 7, true));
            listaAnimales.Add(new Gato("Simba", 2, false));
            listaAnimales.Add(new Gato("Cleo", 4, true));

            // --- PERROS  ---
            listaAnimales.Add(new Perro("Rocco", 2, "Mestizo"));
            listaAnimales.Add(new Perro("Lola", 4, "Labrador"));
            listaAnimales.Add(new Perro("Toby", 1, "Caniche"));
            listaAnimales.Add(new Perro("Thor", 6, "Ovejero Alemán"));
            listaAnimales.Add(new Perro("Bimba", 3, "Bulldog"));
            listaAnimales.Add(new Perro("Milo", 5, "Golden Retriever"));

            // --- CONEJOS  ---
            listaAnimales.Add(new Conejo("Nuvecita", 1, 2.5f));
            listaAnimales.Add(new Conejo("Copito", 2, 1.8f));
            listaAnimales.Add(new Conejo("Tambor", 4, 3.2f));
            listaAnimales.Add(new Conejo("Pelusa", 1, 0.9f));
            listaAnimales.Add(new Conejo("Orejas", 3, 2.7f));
            listaAnimales.Add(new Conejo("Bigotes", 5, 4.1f));


            // LISTA DE ATENCION
            // --- GATOS  ---
            listaAtencion.Add(new Gato("JOJO", 3, true));
            listaAtencion.Add(new Gato("Michi", 1, false));
            listaAtencion.Add(new Gato("Luna", 5, true));
            listaAtencion.Add(new Gato("Garfield", 7, true));
            listaAtencion.Add(new Gato("Simba", 2, false));
            listaAtencion.Add(new Gato("Cleo", 4, true));

            // --- PERROS  ---
            listaAtencion.Add(new Perro("Rocco", 2, "Mestizo"));
            listaAtencion.Add(new Perro("Lola", 4, "Labrador"));
            listaAtencion.Add(new Perro("Toby", 1, "Caniche"));
            listaAtencion.Add(new Perro("Thor", 6, "Ovejero Alemán"));
            listaAtencion.Add(new Perro("Bimba", 3, "Bulldog"));
            listaAtencion.Add(new Perro("Milo", 5, "Golden Retriever"));

            // --- CONEJOS  ---
            listaAtencion.Add(new Conejo("Nuvecita", 1, 2.5f));
            listaAtencion.Add(new Conejo("Copito", 2, 1.8f));
            listaAtencion.Add(new Conejo("Tambor", 4, 3.2f));
            listaAtencion.Add(new Conejo("Pelusa", 1, 0.9f));
            listaAtencion.Add(new Conejo("Orejas", 3, 2.7f));
            listaAtencion.Add(new Conejo("Bigotes", 5, 4.1f));


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

            var animalesFiltro = listaAnimales.Where(animal => animal.Edad > 3);


            foreach (var item in listaAtencion)
            {
                item.Atender();
            }
             */

            Veterinario Profesional1 = new Veterinario("Sebastian", "Especialista de la salud de animales domesticos, Universidad de Buenos Aires");
            DateTime Fecha1 = new DateTime(2026,9,10);
            Turno T1 = new Turno(listaAnimales[6], Profesional1, Fecha1);

            T1.MostrarResumen();

            Console.ReadKey();
        }
    }
}
