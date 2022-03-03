using System;
using System.Globalization;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaBancaria conta;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char validacao = char.Parse(Console.ReadLine());

            while(validacao != 's' && validacao != 'S' && validacao != 'n' && validacao != 'N')
            {
                Console.WriteLine("Digite um valor valido(s/n)");
            }

            if (validacao == 's' || validacao == 'S')
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                conta = new ContaBancaria(numero, nome, saldo);
            }
            else
            {
                conta = new ContaBancaria(numero, nome);
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.Write("Entre com um valor de depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito);
            Console.WriteLine("Dados atualizados da conta: ");
            Console.WriteLine(conta);

            Console.Write("Entre com um valor de saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);
            Console.WriteLine("Dados atualizados da conta: ");
            Console.WriteLine(conta);

        }
    }
}
