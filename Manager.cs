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
            base.DisplayInfo();
            Console.WriteLine($"Bonus: {Bonus}");
        }

        public double CalculateTotalSalary()
        {
            double totalSalary = Salary + Bonus;
            return totalSalary;
        }
    }
}
