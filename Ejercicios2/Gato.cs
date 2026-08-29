using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios2
{
    class Gato : Animal, IAtendible
    {
        public bool EsDeInterior { get; set; }

        public Gato (string nombre, int edad, bool esDeInterior)
        {
            this.Nombre = nombre;
            this.EsDeInterior = esDeInterior;
            this.Especie = "Gato";
            this.Edad = edad;
        }

        public override void Describir()
        {
            Console.WriteLine("---------------");
            base.Describir();
            Console.WriteLine("Es de Interior: " + this.EsDeInterior + "\n--------------");
        }

        public void Atender()
        {
            Console.WriteLine("Atendiendo al gato " + this.Nombre + ": desparasitación.");
        }
    }
}
