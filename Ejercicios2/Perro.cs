using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios2
{
    class Perro : Animal
    {
        public string raza { get; set; }

        public Perro (string nombre, int edad, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
            this.especie = "Perro";

            if (edad >= 0)
            {
                this.edadPublic = edad;
            }
            else
            {
                this.edadPublic = 0;
            }
        }

        public override void describir()
        {
            base.describir();
            Console.WriteLine("Raza: " + this.raza);
        }
    }
}
