using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask2
{
    internal class Employee
    {
        private int id;
        private string name;
        private double salary;

        public int Id {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Salary
        {
            get { return salary; }
            set {
                if (value >= 0)
                    salary = value;
                else
                    throw new ArgumentException("Salary cannot be negative.");
            }
        }

        public virtual void DisplayInfo()
        {
            Console.Write($"Id: {Id}, Name: {Name}, Salary: {Salary} ");
        }
    }
}
