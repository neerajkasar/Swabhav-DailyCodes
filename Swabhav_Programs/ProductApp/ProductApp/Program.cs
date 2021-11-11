using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductApp.Model;

namespace ProductApp
{
    class Program
    {
        static void Main(string[] args)
        {
          CaseStudy1();
            Console.ReadLine();
            CaseStudy2();
            Console.WriteLine(Product.Occurance);
            Console.ReadLine();

        }
        static void PrintDetails(Product p)
        {
            Console.WriteLine($"Id {p.GetId()} Name {p.Name()} Price: {p.Price()} Discount {p.DiscountPercent()}");
        }
        static void CaseStudy1()
        {
            Product p1 = new Product(101,"Headfirst Java",500);
            PrintDetails(p1);
            Product p2 = new Product(101, "Headfirst c#", 500, 10);
        }

        static void CaseStudy2()
        {
            Product p1 = new Product(101,"Headfirst Java",500);
            PrintDetails(p1);
            Console.WriteLine($"Occurance is {p1.InstanceCount}");
            Product p2 = new Product(101, "Headfirst c#", 500, 10);
            PrintDetails(p2);
            Console.WriteLine($"Occurance is {p2.InstanceCount}");

        }
    }
}
