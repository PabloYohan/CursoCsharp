using System;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            Rent[] vect = new Rent[10];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Rent #"+(i+1));
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int numero = int.Parse(Console.ReadLine());

                vect[numero-1] = new Rent(nome, email, numero);
            }

            Console.WriteLine("Busy rooms:");
            for(int i = 0; i < 10; i++)
            {
                if(vect[i] != null)
                {
                    Console.WriteLine(vect[i]);
                }
            }
        }
    }
}
