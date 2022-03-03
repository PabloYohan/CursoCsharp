using System;
using System.Collections.Generic;
using System.Globalization;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            double aument;
            List<Employee> list = new List<Employee>();
            Console.Write("How many employees will be registered? ");
            int N = int.Parse(Console.ReadLine());

            for(int i = 0; i < N; i++)
            {
                Console.WriteLine($"Employee #{i+1}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                list.Add(new Employee(id, name, salary));
            }


            Console.Write("Enter the employee id that will have salary increase: ");
            int a = int.Parse(Console.ReadLine());
            int aux = list.FindIndex(x => x.Id == a);

            if(aux == -1)
            {
                Console.WriteLine("This id does not exist! ");
            }
            else
            {
                Console.Write("Enter the percentage: ");
                aument = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list[aux].Aument(aument);
            }

            Console.WriteLine();

            Console.WriteLine("Updated list of employees:");
            foreach(Employee obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
