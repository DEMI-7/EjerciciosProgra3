using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios2
{
    internal class Cliente
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        private List<Animal> Mascotas = new List<Animal>();

        public void AgregarMascota (Animal a)
        {
            this.Mascotas.Add(a);
        }
        public void MostrarMascotas()
        {
            foreach(var item in Mascotas)
            {
                item.Describir();
            }
        }

    }
}
