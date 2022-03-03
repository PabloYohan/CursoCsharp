using System;
using System.Globalization;


namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(x >= 0 && x <= 25)
            {
                Console.WriteLine("intervalo [0,25]");
            }
            else if(x > 25 && x<= 50)
            {
                Console.WriteLine("intervalo (25,50]");
            }
            else if(x > 50 && x<= 75)
            {
                Console.WriteLine("intervalo (50,75]");
            }
            else if(x>75 && x <= 100)
            {
                Console.WriteLine("intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}
