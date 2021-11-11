using System;
using AccountToStringEqualityApp.Model;
using System.Runtime;

namespace AccountToStringEqualityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            Console.ReadLine();
        }
        static void CaseStudy1()
        {
            Customer c = new Customer("Neeraj", 19999);
            Console.WriteLine(c.GetType());
            Console.WriteLine(c.ToString());

        }
        static void CaseStudy2()
        {
            Customer c1 = new Customer("Neeraj", 19999,100);
            Customer c2 = new Customer("Neeraj", 19999,100);
            c1.IDD.Equals(c2.IDD);
            Console.WriteLine();

        }
    }
}
