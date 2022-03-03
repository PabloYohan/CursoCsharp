using System;
using System.Globalization;

namespace exercicio4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double v = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double s = h * v;

            Console.WriteLine($"NUMERO = {n}");
            Console.WriteLine("Salario = U$" + s.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
