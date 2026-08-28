namespace Ejercicios2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro p1 = new Perro("Rocco", 2, "Mestizo");
            Gato g1 = new Gato("JOJO", 3, true);

            p1.describir();
            g1.describir();
        }
    }
}
