using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dados = Console.ReadLine().Split(' ');

            int A = int.Parse(dados[0]);
            int B = int.Parse(dados[1]);

            if (A == B)
            {
                Console.WriteLine("São multiplos");
            }
            else if (A > B)
            {
                if (A % B == 0)
                {
                    Console.WriteLine("São multiplos");
                }
                else
                {
                    Console.WriteLine("Não são multiplos");
                }
            }
            else
            {
                if(B % A == 0)
                {
                    Console.WriteLine("São multiplos");
                }
                else
                {
                    Console.WriteLine("Não são multiplos");
                }
            }
        }
    }
}
