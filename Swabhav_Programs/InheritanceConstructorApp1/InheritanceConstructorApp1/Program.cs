using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceConstructorApp1.Model;

namespace InheritanceConstructorApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            Console.ReadLine();
        }
        static void CaseStudy1()
        {
            Console.WriteLine("Case1");
            Parent p = new Parent();
            Child c = new Child();
        }
    }
}
