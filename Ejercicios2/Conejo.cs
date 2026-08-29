using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios2
{
    public class Conejo : Animal, IAtendible
    {
        private float _peso;
        public float Peso
        { 
            get
            {
                return this._peso;
            }
            set
            {
                if (value > 0)
                {
                    this._peso = value;
                }
                else
                {
                    this._peso = 0;
                }
            }
        }

        public Conejo(string nombre, int edad, float peso)
        {
            this.Nombre = nombre;
            this.Peso = peso;
            this.Especie = "Conejo";
            this.Edad = edad;
        }

        public override void Describir()
        {
            Console.WriteLine("---------------");
            base.Describir();
            Console.WriteLine("Peso: " + this.Peso + "\n--------------");
        }

        public void Atender()
        {
            Console.WriteLine("Atendiendo al Conejo " + this.Nombre + ": control de peso.");
        }

        public override void HacerSonido()
        {
            Console.WriteLine("Squeak");
        }
    }
}
