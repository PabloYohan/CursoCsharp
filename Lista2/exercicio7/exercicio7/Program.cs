using System;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            double x = double.Parse(s[0]);
            double y = double.Parse(s[1]);

            if( x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if(x >=0 && y >= 0)
            {
                Console.WriteLine("Q1");
            }
            else if(x <= 0 && y >= 0)
            {
                Console.WriteLine("Q2");
            }
            else if(x <= 0 && y <= 0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }
    }
}
