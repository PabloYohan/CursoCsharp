using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            while(x != 2002)
            {
                Console.WriteLine("Senha inválida");
                x = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}
