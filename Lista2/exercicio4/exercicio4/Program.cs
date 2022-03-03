using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo = 0;

            string[] s = Console.ReadLine().Split(' ');

            int A = int.Parse(s[0]);
            int B = int.Parse(s[1]);

            if (A >= B)
            {
                tempo = 24 - A + B;
            }
            else
            {
                tempo = B - A;
            }

            Console.WriteLine($"O jogo durou {tempo} hora(s)");
        }
    }
}
