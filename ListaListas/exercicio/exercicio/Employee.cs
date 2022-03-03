using System;
using System.Collections.Generic;

namespace exercicio
{
    class Employee
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void Aument(double x)
        {
            Salary += Salary * (x / 100);
        }

        public override string ToString()
        {
            return Id +
                ", " +
                Name +
                ", " +
                Salary;
        }

    }
}
