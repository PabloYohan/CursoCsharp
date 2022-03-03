using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string[] s = Console.ReadLine().Split(' ');

            double x = double.Parse(s[0]);
            double y = double.Parse(s[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro");
                }
                else
                {
                    Console.WriteLine("Quarto");
                }

                s = Console.ReadLine().Split(' ');

                x = double.Parse(s[0]);
                y = double.Parse(s[1]);
            }
        }
    }
}
