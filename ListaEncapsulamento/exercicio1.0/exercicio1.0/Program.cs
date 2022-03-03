using System;
using System.Globalization;

namespace exercicio1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            char validacao;
            int numero;
            string nome;
            double saldo;

            ContaBancaria contaB = new ContaBancaria();

            Console.Write("Entre com o número da conta: ");
            numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            validacao = char.Parse(Console.ReadLine());

            if (validacao == 's' || validacao == 'S')
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                contaB = new ContaBancaria(numero, nome, saldo);
            }
            else if (validacao == 'n' || validacao == 'N')
            {
                contaB = new ContaBancaria(numero, nome);
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(contaB);
        }
    }
}
