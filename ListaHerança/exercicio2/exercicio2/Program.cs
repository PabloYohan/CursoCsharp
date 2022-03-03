using System;
using System.Globalization;
using System.Collections.Generic;
using exercicio2.Entities;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char a = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(a == 'i' || a == 'I')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(name, price, customsFee));
                }
                else if(a == 'u' || a == 'U')
                {
                    Console.Write("Manufacture date(DD/MM/YYYY) : ");
                    DateTime dateTime = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, dateTime));
                }
                else
                {
                    products.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product c in products)
            {
                Console.WriteLine(c.PriceTag());
            }
        }
    }
}
