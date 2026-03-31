namespace OOPTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.Id = 1;
            manager.Name = "Ahmed";
            manager.Salary = 8000;
            manager.Bonus = 2000;
            manager.DisplayInfo();
            manager.CalculateTotalSalary();

            Developer developer = new Developer();
            developer.Id = 2;
            developer.Name = "Sara";
            developer.Salary = 6000;
            developer.ProgrammingLanguage = "C#";
            developer.DisplayInfo();
        }
    }
}
