using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 0.0;
            string[] pedido = Console.ReadLine().Split(' ');

            int A = int.Parse(pedido[0]);
            int B = int.Parse(pedido[1]);

            if (A == 1)
            {
                valor = 4 * B;
            }
            else if (A == 2)
            {
                valor = 4.50 * B;
            }
            else if (A == 3)
            {
                valor = 5 * B;
            }
            else if (A == 4)
            {
                valor = 2 * B;
            }
            else if (A == 5)
            {
                valor = 1.50 * B;
            }
            else
            {
                Console.WriteLine("Codigo não encontrado");
            }

            Console.WriteLine($"Total: R${valor:F2}");
        }
    }
}
