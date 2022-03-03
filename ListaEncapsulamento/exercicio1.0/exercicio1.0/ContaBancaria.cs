using System;
using System.Globalization;

namespace exercicio1._0
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }


        public ContaBancaria()
        {

        }
        public ContaBancaria(int conta, string nome)
        {
            Numero = conta;
            Nome = nome;
        }

        public ContaBancaria(int conta, string nome, double saldo) : this(conta, nome)
        {
            Saldo = saldo;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5;
        }

        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Nome
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
