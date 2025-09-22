using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetterSetter
{
    //Gatter and Setter

    class Income
    {
        private double salary; // field
        public double Salary   // property
        {
            get { return salary; }   // getter
            set
            {
                if (salary <= 0)
                {
                    salary = 0;
                }
                else
                {
                    salary = value;
                }  // setter
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Income inc = new Income();
                inc.Salary = 45000; // setter
                Console.WriteLine("Salary: " + inc.Salary); // getter
                inc.Salary -= 75000; // setter
                Console.WriteLine("Updated Salary: " + inc.Salary); // getter

            }
        }
    }
}
