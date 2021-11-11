using System;
using UniqueIdApp.Model;

namespace UniqueIdApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy();
            Console.ReadLine();
        }
        static void PrintDetails(Customer c)
        {
            Console.WriteLine($"Id: {Customer.Id} Name: {c.Name} Expense: {c.Expense}");
        }
        static void CaseStudy()
        {
            //int property, method;
            Customer c1 = new Customer("Neeraj", 10000);
            PrintDetails(c1);
            Customer c2 = new Customer("Raj", 1244);
            PrintDetails(c2);
            Customer c3 = new Customer("Ram", 33333);
            PrintDetails(c3);
        }
    }
}
