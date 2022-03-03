using System;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] numeros = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

                for(int j =0; j < n; j++)
                {
                    numeros[i,j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine("Diagonal principal: ");
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(i == j)
                    {
                        Console.Write(numeros[i,j] + " ");
                    }
                }
            }

            Console.WriteLine();

            int count = 0;

            for(int i = 0; i < n; i++)
            {
                for(int j = 0;j < n; j++)
                {
                    if(numeros[i,j] < 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine("Negative numbers: "+ count);
        }
    }
}
