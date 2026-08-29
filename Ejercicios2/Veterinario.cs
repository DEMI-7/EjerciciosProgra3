using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios2
{
    public class Veterinario
    {
        public string Nombre {  get; set; }
        public string Matricula { get; set; }

        public Veterinario(string Nombre, string Matricula)
        {
            this.Nombre = Nombre;
            this.Matricula = Matricula;
        }

        public void Describir()
        {
            Console.WriteLine("Nombre del Profesional: " + this.Nombre + "\nMatricula: " + this.Matricula);
        }
    }
}
