using System;
using System.Collections.Generic;
using System.Globalization;
using exercicio.Entities;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(type == 'I' || type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new IndividualTaxPayer(name, income, health));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new CompanyTaxPayer(name, income, employees));
                }
            }
            Console.WriteLine();
            double soma = 0.0;
            Console.WriteLine("TAXES PAID: ");
            foreach(TaxPayer acc in list)
            {
                double tax = acc.TaxesPaid();
                Console.WriteLine(acc.Name + ": $" + tax.ToString("F2", CultureInfo.InvariantCulture));
                soma += tax;
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ "+ soma.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
