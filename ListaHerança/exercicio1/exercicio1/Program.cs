using System;
using System.Globalization;
using System.Collections.Generic;
using exercicio1.Entities;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Console.Write("Enter the number of employee: ");
            int n = int.Parse(Console.ReadLine());

            for(int i =1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                string a = Console.ReadLine();

                while(a != "N" && a != "n" && a != "Y" && a!= "y")
                {
                    Console.Write("Invalid value!!! Please (y/n)");
                    a = Console.ReadLine();
                }

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(a == "n" || a == "N")
                {
                    Employee employee = new Employee(name, hours, valuePerHour);
                    list.Add(employee);
                }
                else
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Employee employee = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);
                    list.Add(employee);
                }
            }

            Console.WriteLine();

            Console.WriteLine("PAYMENTS: ");
            foreach(Employee c in list)
            {
                Console.WriteLine(c);
            }
        }
    }
}
