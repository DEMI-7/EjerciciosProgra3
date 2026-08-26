using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios1
{
    class Cafetera
    {
        private int capacidadMl;
        private int nivelMl;

        public Cafetera()
        {
            this.capacidadMl = 1000;
            this.nivelMl = 0;
        }

        public Cafetera(int capacidadInicial, int nivelInicial)
        {
            if (capacidadInicial >= 0 && nivelInicial >= 0 && (nivelInicial <= capacidadInicial))
            {
                this.capacidadMl = capacidadInicial;
                this.nivelMl= nivelInicial;
            }
            else
            {
                Console.WriteLine("Solo admite valores Mayores a 0");
                this.nivelMl = 0;
                this.capacidadMl = 0;
            }
        }

        public void cargar(int cantidadMl)
        { 
            if(cantidadMl <= 0)
            {
                Console.WriteLine("Solo se admiten capacidades mayores a 0");
                return;
            }
            if ((cantidadMl + nivelMl) > capacidadMl)
            {
                Console.WriteLine("Capacidad superada. Se cargó hasta el máximo.");
                this.nivelMl = capacidadMl;
            }
            else
            {
                this.nivelMl += cantidadMl;
            }
        }

        public int servirTaza()
        {
            int capacidadTaza = 200;
            if (nivelMl >= capacidadTaza)
            {
                this.nivelMl -= capacidadTaza;
                return capacidadTaza;
            }
            else
            {
                int cantidadServida = nivelMl;
                nivelMl = 0;
                return cantidadServida;
            }
        }
        public int servirTaza(int cantidad)
        {            
            if (nivelMl >= cantidad)
            {
                this.nivelMl -= cantidad;
                return cantidad;
            }
            else
            {
                Console.WriteLine("No hay suficiente cafe para servir esa cantidad");
                return 0;
            }
        }

        public void mostrarEstado()
        {
            Console.WriteLine("Nivel: " + nivelMl + "/" + capacidadMl + "Ml");
        }

    }
}
