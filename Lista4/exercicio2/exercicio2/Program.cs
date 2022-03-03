using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int dentro = 0;
            int fora = 0;

            int N = int.Parse(Console.ReadLine());
            int valor = 0;

            for(int i = 1; i <= N; i++)
            {
                valor = int.Parse(Console.ReadLine());
                
                if (valor >= 10 && valor <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }

            Console.WriteLine($"{dentro} in");
            Console.WriteLine($"{fora} out");
        }
    }
}
