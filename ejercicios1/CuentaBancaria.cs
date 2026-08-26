using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios1
{
    class CuentaBancaria
    {
        private string numeroCuenta;
        private string titular;
        private float saldo;

        public CuentaBancaria(string numeroCuenta, string titular)
        {
            this.titular = titular;
            this.numeroCuenta = numeroCuenta;
            this.saldo = 0.0f;
        }

        public CuentaBancaria(string numeroCuenta, string titular, float saldoInicial)
        {
            this.titular = titular;
            this.numeroCuenta = numeroCuenta;
            this.saldo = saldoInicial;
        }

        // ------ METODOS -----

        public void depositar(float monto)
        {
            if (monto > 0.0f)
            {
                this.saldo += monto;
            }
            else
            {
                Console.WriteLine("Monto invalido. Solo valoresn mayores a 0.");
            }
        }

        public bool extraer(float monto)
        {
            if (monto <= this.saldo)
            {
                this.saldo -= monto;
                return true;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }
        }

        public void consultarSaldo()
        {
            Console.WriteLine( titular + " tiene un saldo de: $" + saldo);
        }

        public string getTitular()
        {
            return titular;
        }

        public string getNumeroCuenta()
        {
            return numeroCuenta;
        }
    }
}
