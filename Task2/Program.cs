using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee= new Employee();

            employee.CompanyName = "General Supply";
            employee.FullName = "Someone";
            employee.Salary = 1000;
            employee.Worker(employee.FullName,employee.Salary);
            employee.Service("Supply Chain Management");
        }
    }
}
