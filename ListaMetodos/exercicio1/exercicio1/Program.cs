using System;
using System.Globalization;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo A;
            A = new Retangulo();

            double area, perimetro, diagonal;

            Console.WriteLine("Entre com a largura e altura do retângulo: ");
            A.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = A.Area();
            perimetro = A.Perimetro();
            diagonal = A.Diagonal();

            Console.WriteLine("Area = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro = " + perimetro.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal= " + diagonal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
