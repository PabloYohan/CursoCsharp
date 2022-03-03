using System;
using System.Globalization;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dolar? ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorfinal = ConversorDeMoeda.Valor(valor, quantidade);

            Console.WriteLine("Valor a ser pago em reais = " + valorfinal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
