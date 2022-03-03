using System;

namespace Auladados
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo = 1000.5768;
            string nome = "Pablo";
            int idade = 19;

            Console.WriteLine($"{nome} tem {idade} anos e tem saldo de {saldo:F2} reais");

        }
    }
}
