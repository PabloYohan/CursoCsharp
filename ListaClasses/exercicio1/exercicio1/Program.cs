using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa A, B;
            A = new Pessoa();
            B = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            A.Nome = Console.ReadLine();
            Console.Write("idade: ");
            A.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            B.Nome = Console.ReadLine();
            Console.Write("idade: ");
            B.idade = int.Parse(Console.ReadLine());

            if (A.idade > B.idade)
            {
                Console.WriteLine($"Pessoa mais velha: {A.Nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {B.Nome}");
            }

        }
    }
}
