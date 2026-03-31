using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask2
{
    internal class Developer : Employee
    {
        private string programmingLanguage;

        public string ProgrammingLanguage {
            get {return programmingLanguage;}
            set {programmingLanguage = value;}
        }

        public void DisplayDeveloperInfo()
        {
            Console.WriteLine($"Language: {programmingLanguage}");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Language: {programmingLanguage}");
        }
    }
}
