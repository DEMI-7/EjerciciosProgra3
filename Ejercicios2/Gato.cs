using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios2
{
    class Gato : Animal
    {
        public bool esDeInterior { get; set; }

        public Gato (string nombre, int edad, bool esDeInterior)
        {
            this.nombre = nombre;
            this.esDeInterior = esDeInterior;
            this.especie = "Gato";
            
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
            Console.WriteLine("Es de Interior: " + this.esDeInterior);
        }

    }
}
