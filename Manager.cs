using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask2
{
    internal class Manager : Employee
    {
        private double bonus;

        public double Bonus {  
            get { return bonus; } 
            set {
                if (value >= 0)
                    bonus = value;
                else
                    throw new ArgumentException("Bounus cannot be negative.");
            } 
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Manager:");
            Console.WriteLine($"ID: {Id}, Name: {Name}, Salary: {Salary}, Bonus: {Bonus}");
        }

        public void CalculateTotalSalary()
        {
            double totalSalary = Salary + Bonus;
            Console.WriteLine($"Total Salary: {totalSalary}");
        }
    }
}
