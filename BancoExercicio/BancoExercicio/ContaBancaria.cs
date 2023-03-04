using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BancoExercicio
{
    internal class ContaBancaria
    {
        //Auto properties
      public int Numero { get; private set; }
      public string Titular { get; set; }

      public double Saldo { get; private set; }

        //Construtor
        public ContaBancaria(int numero, string titular) {
            Numero = numero;
            Titular = titular;
        }

        //Construtor com sobrecarga
        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular) {
            Deposito(saldo);
        }

        //Metodos
        public void Deposito(double quantia) {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        //Padronizar apresentação com ToString
        public override string ToString()
        {
            return "Conta: " + Numero + ", Titular: " + Titular + ", Saldo: $" + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}
