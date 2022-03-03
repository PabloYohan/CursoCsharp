using System;
using System.Globalization;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s1 = Console.ReadLine().Split();
            int c1 = int.Parse(s1[0]);
            int q1 = int.Parse(s1[1]);
            double v1 = double.Parse(s1[2], CultureInfo.InvariantCulture);

            string[] s2 = Console.ReadLine().Split();
            int c2 = int.Parse(s2[0]);
            int q2 = int.Parse(s2[1]);
            double v2 = double.Parse(s2[2], CultureInfo.InvariantCulture);

            double total = (q1 * v1) + (q2 * v2);

            Console.WriteLine("Total a pagar = R$" + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
