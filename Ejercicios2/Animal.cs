using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios2
{
    public abstract class Animal
    {
        public string Nombre { get; set; }
        private int _edad;
        public int Edad
        { 
            get { return _edad; } 
            set
            {
                if (value >= 0)
                {
                    _edad = value;
                }
                else
                {
                    _edad = 0;
                }
            } 
        }
        public string Especie {get; set;}

        public Animal()
        {
            this.Nombre = string.Empty;
            this._edad = 0;
            this.Especie = string.Empty;
        }

        public Animal(string nombre , int edad, string especie)
        {
            this.Nombre = nombre;
            this.Especie = especie;
            this.Edad = edad;
        }

        public virtual void Describir ()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Edad: " + Edad);
            Console.WriteLine("Especie: " + Especie);
        }
    }
}
