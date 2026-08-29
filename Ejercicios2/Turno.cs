using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios2
{
    public class Turno
    {
        public Animal Paciente { get; set; }
        public Veterinario Profesional { get; set; }
        public DateTime FechaHora { get; set; }

        public Turno (Animal Paciente, Veterinario Profesional, DateTime FechaHora)
        {
            this.Paciente = Paciente;
            this.Profesional = Profesional;
            this.FechaHora = FechaHora;
        }

        public void MostrarResumen ()
        {
            Console.WriteLine("----------");
            Console.WriteLine("Veterinaria Patitas Felices");
            Console.WriteLine("----------");
            Console.WriteLine("Fecha del turno: " + FechaHora);
            this.Profesional.Describir();
            Console.WriteLine("\nDatos del paciente: ");
            this.Paciente.Describir();
        }
    }
}
