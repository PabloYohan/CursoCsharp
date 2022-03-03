using System;
using System.Globalization;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno A = new Aluno();

            Console.Write("Nome do Aluno: ");
            A.Nome = Console.ReadLine();
            Console.WriteLine("Digite as tres notas do aluno");
            A.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double notafinal = A.NotaFinal();

            Console.WriteLine("Nota Final = " + notafinal.ToString("F2", CultureInfo.InvariantCulture));
            if(notafinal > 60)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
                double restante = 60 - notafinal;
                Console.WriteLine("Faltaram "+ restante.ToString("F2",CultureInfo.InvariantCulture) + " pontos");
            }
        }
    }
}
