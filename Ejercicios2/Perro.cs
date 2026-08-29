using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios2
{
    class Perro : Animal, IAtendible
    {
        public string Raza { get; set; }

        public Perro (string nombre, int edad, string raza)
        {
            this.Nombre = nombre;
            this.Raza = raza;
            this.Especie = "Perro";
            this.Edad = edad;
        }

        public override void Describir()
        {
            Console.WriteLine("---------------");
            base.Describir();
            Console.WriteLine("Raza: " + this.Raza + "\n--------------");
        }

        public void Atender()
        {
            Console.WriteLine("Atendiendo al perro " + this.Nombre + ": revisión general y vacunas.");
        }

        public override void HacerSonido()
        {
            Console.WriteLine("whoof whoof");
        }
    }
}
