using System.Numerics;

namespace ejercicios1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----- PRUEBA DEL PORTON -----
            /* 
            PortonAutomatico portonCasa = new PortonAutomatico();

            Console.WriteLine("Prueba 1");
            portonCasa.mostrarEstado();
            portonCasa.abrir();
            portonCasa.mostrarEstado();

            Console.WriteLine("Prueba 2");
            portonCasa.abrirPeatonal();
            portonCasa.mostrarEstado();

            Console.WriteLine("Prueba 3");
            portonCasa.cerrar();
            portonCasa.mostrarEstado();

            Console.WriteLine("Prueba 4");
            portonCasa.abrir(105);
            portonCasa.mostrarEstado();

            Console.WriteLine("Prueba 5");
            for (int i = 1; i <= 10; i++)
            {
                portonCasa.abrir(i * 10);
                portonCasa.mostrarEstado();
                if(i*10 >= 50)
                {
                    portonCasa.stop();
                    i = 11;
                }
            }
            */

            // ----- PRUEBAS CUENTA BANCARIA -----

            CuentaBancaria[] servidorMP = new CuentaBancaria[10];

            servidorMP[0] = new CuentaBancaria("1", "Demian", 20000);
            servidorMP[1] = new CuentaBancaria("2", "Maxi Programa", 100000);

            servidorMP[0].consultarSaldo();
            servidorMP[1].consultarSaldo();

            /*
            servidorMP[0].consultarSaldo();
            servidorMP[0].depositar(10000);
            servidorMP[0].consultarSaldo();
            servidorMP[0].extraer(12000);
            servidorMP[0].consultarSaldo();
            servidorMP[0].extraer(100000);
             */


            transferenciaBancaria(ref servidorMP, "2","1", 20000);

            servidorMP[0].consultarSaldo();
            servidorMP[1].consultarSaldo();


        }

        static void transferenciaBancaria(ref CuentaBancaria[] servidorMP, string cbuDepositante, string cbuReceptor, float monto)
        {
            int posDepositante = -1; int posReceptor = -1;

            for (int i = 0; i < servidorMP.Length; i++)
            {
                if(servidorMP[i] != null && (posDepositante == -1 || posReceptor == -1))
                {
                    if (servidorMP[i].getNumeroCuenta() == cbuDepositante)
                    {
                        posDepositante = i;
                    }
                    if (servidorMP[i].getNumeroCuenta() == cbuReceptor)
                    {
                        posReceptor = i;
                    }
                }
            }

            if( posDepositante == -1 || posReceptor == -1)
            {
                Console.WriteLine("Fallo al encontrar el CBU");
                Console.WriteLine("Transferencia interrumpida.");
                return;
            }

            if (servidorMP[posDepositante].extraer(monto))
            {
                servidorMP[posReceptor].depositar(monto);
                Console.WriteLine("-----Transferencia exitosa.-----");
                Console.WriteLine("Depositante: " + servidorMP[posDepositante].getTitular());
                Console.WriteLine("Receptor: " + servidorMP[posReceptor].getTitular());
                Console.WriteLine("Monto de la transaccion: $" + monto);
            }
            else
            {
                Console.WriteLine("Transferencia interrumpida.");
            }
        }
    }
}
