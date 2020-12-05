using Epam_Customer_Class_Challenge_MaralovKemal;
using System;

namespace CustomerConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer("Jeffrey Richter", "+1 (425) 555-0100", 1000000);
            Console.WriteLine(customer.ToString("C"));
        }
    }
}
