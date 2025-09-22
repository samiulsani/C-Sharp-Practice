using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getter_Setter
{
    internal class Program
    {
        class Income
        {
            private double salary; // Private field to store the salary
            public double Salary
            {
                get { return salary; } // Getter to access the salary
                set
                {
                    if (value >= 0) // Validation to ensure salary is non-negative
                    {
                        salary = value;
                    }
                    else
                    {
                        throw new ArgumentException("Salary cannot be negative");
                    }
                }
            }

            static void Main(string[] args)
            {
                Income income = new Income();
                income.salary = 2000; // Using the setter to set the salary
                Console.WriteLine("Salary: " + income.salary); // Using the getter to get the salary

            }
        }
    }
}
