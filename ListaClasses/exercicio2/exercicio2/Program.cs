using System;
using System.Globalization;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios A, B;
            double media;

            A = new Funcionarios();
            B = new Funcionarios();

            Console.WriteLine("Dados do primeiro funcionario: ");
            Console.Write("Nome: ");
            A.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            A.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados do segundo funcionario: ");
            Console.Write("Nome: ");
            B.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            B.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (A.salario + B.salario) / 2;

            Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
