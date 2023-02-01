using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    internal class Employee : Company
    {
        public string FullName;
        public int Salary;
        public override void Worker(string fullname, int salary)
        {
            Console.WriteLine($"FullName: {fullname} and Salary: {salary}");
        }
    }
}
