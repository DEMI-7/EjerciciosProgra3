using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ejercicios1
{
    class PortonAutomatico
    {
        private int apertura;
        private bool estaCerrado;
        private bool estaAbiertoCompleto;

        // El porton comnienza con una apertura = 0, y esta cerrado.
        public PortonAutomatico()
        {
            this.apertura = 0;
            actualizarEstado();
        }

        // El porton comienza con un valor inicial de apertura, valores validos entre 0 y 100, ambos incluidos
        public PortonAutomatico (int apertura)
        {
            if (apertura >= 0 || apertura <= 100)
            {
                this.apertura = apertura;
            }
            else if (apertura < 0)
            {
                this.apertura = 0;
            }
            else if (apertura > 100)
            {
                apertura = 100;
            }
            actualizarEstado();
        }

        // Setea la apertura a 100
        public void abrir()
        {
            if (estaAbiertoCompleto)
            {
                Console.WriteLine("Ya esta abierto al 100%");
                return;
            }
            this.apertura = 100;
            actualizarEstado();
        }

        public void abrir(int apertura)
        {
            if (apertura == 100)
            {
                abrir();
            }
            else if (apertura > 0 && apertura < 100)
            {
                this.apertura = apertura;
                actualizarEstado();
            }
            else
            {
                Console.WriteLine("Solo validos numeros del 1 al 100");
            }
        }

        public void abrirPeatonal()
        {
            this.apertura = 20;
            actualizarEstado();
        }

        public void stop()
        {
            Console.WriteLine("Movimiento detenido");
        }

        public bool togggle()
        {
            if (estaCerrado)
            {
                abrir();
                return true;
            }
            else
            {
                cerrar();
                return false;
            }
        }

        // Cierra la apertua a 0
        public void cerrar()
        {
            if (estaCerrado)
            {
                Console.WriteLine("Ya esta cerrado");
                return;
            }
            this.apertura = 0;
            actualizarEstado();
        }

        public void mostrarEstado()
        {
            if (estaAbiertoCompleto)
            {
                Console.WriteLine("Abierto al 100%");
            }
            else if (estaCerrado)
            {
                Console.WriteLine("Cerrado");
            }
            else
            {
                Console.WriteLine("Abierto parcial al " + this.apertura + "%");
            }
        }

        private void actualizarEstado()
        {
            if (apertura > 0 && apertura < 100) { this.estaCerrado = false; this.estaAbiertoCompleto = false;}
            if (apertura == 0) { this.estaCerrado = true; this.estaAbiertoCompleto = false;}
            if (apertura == 100) { this.estaCerrado = false; this.estaAbiertoCompleto = true; }
        }
    }
}
