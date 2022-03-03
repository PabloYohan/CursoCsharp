using System;
using System.Globalization;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i <= N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

                double a = double.Parse(s[0], CultureInfo.InvariantCulture);
                double b = double.Parse(s[1], CultureInfo.InvariantCulture);
                double c = double.Parse(s[2], CultureInfo.InvariantCulture);

                double media = (2.0 * a + 3.0 * b + 5.0 * c) / 10;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
