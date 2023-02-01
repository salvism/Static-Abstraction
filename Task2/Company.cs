using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    internal abstract class Company : IService
    {
        public string CompanyName; //Her bir shirketin adi olmalidir

        public void Service(string service)
        {
            Console.WriteLine($"Company Name: {CompanyName} / Service: {service}");   
        }

        public abstract void Worker(string fullname, int salary); //Her bir shriketin ishcisi olmalidir

    }
}
