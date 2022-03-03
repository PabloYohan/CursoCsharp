using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int gasolina, alcool, diesel;
            gasolina = 0;
            alcool = 0;
            diesel = 0;
            int valor = int.Parse(Console.ReadLine());

            while (valor != 4)
            {
                if (valor == 2)
                {
                    gasolina++;
                }
                else if(valor == 1)
                {
                    alcool++;
                }
                else if(valor == 3)
                {
                    diesel++;
                }
             
                valor = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Muito obrigado");
            Console.WriteLine($"Alcool = {alcool}");
            Console.WriteLine($"Gasolina = {gasolina}");
            Console.WriteLine($"Diesel = {diesel}");
        }
    }
}
