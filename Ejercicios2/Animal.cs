using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios2
{
    class Animal
    {
        public string nombre { get; set; }
        private int edadPrivate;
        public int edadPublic
        { 
            get { return edadPrivate; } 
            set
            {
                if (value >= 0)
                {
                    edadPrivate = value;
                }
                else
                {
                    edadPrivate = 0;
                }
            } 
        }
        public string especie {get; set;}

        public Animal()
        {
            this.nombre = string.Empty;
            this.edadPublic = 0;
            this.especie = string.Empty;
        }

        public Animal(string nombre , int edad, string especie)
        {
            this.nombre = nombre;
            this.especie = especie;
            
            if (edad >= 0)
            {
                this.edadPublic = edad;
            }
            else
            {
                edad = 0;
            }
        }

        public virtual void describir ()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edadPrivate);
            Console.WriteLine("Especie: " + especie);
        }
    }
}
