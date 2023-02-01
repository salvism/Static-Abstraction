using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Name = "Someone";
            Student student2 = new Student();
            student2.Name = "Anyone";
            Console.WriteLine(student1.CheckGroupNo("P231"));
            Console.WriteLine(student1.No);
            Console.WriteLine(student2.No);
        }
    }
}
