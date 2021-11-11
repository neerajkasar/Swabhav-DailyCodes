using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceApp.Model;

namespace InheritanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            CaseStudy3();
            CaseStudy4();
            CaseStudy5();
            Console.ReadLine();
        }
        static void CaseStudy1()
        {
            Console.WriteLine("CaseStudy:1");
            Man x;
            x = new Man();
            x.Walk();
            x.Play();
            x.Read();

        }
        static void CaseStudy2()
        {
            Console.WriteLine();
            Console.WriteLine("CaseStudy:2");
            Boy y;
            y = new Boy();
            y.Play();
            y.Jump();
            y.Walk();
            y.Read();

        }
        static void CaseStudy3()
        {
            Console.WriteLine();
            Console.WriteLine("CaseStudy:3");
            Man x;
            x = new Boy();
            x.Read();
            x.Play();
            x.Walk();
        }
        static void CaseStudy4()
        {
            Console.WriteLine();
            Console.WriteLine("CaseStudy:4");
            AtThePark(new Man());
            AtThePark(new Boy());
            AtThePark(new Kid());
            AtThePark(new Infant());
        }
        static void AtThePark(Man x)
        {
            Console.WriteLine("At the Park");
            x.Play();
        }
        static void CaseStudy5()
        {
            Console.WriteLine("CaseStudy5: ");
            object x;
            
            x =10 ;
            Console.WriteLine(x.GetType());
            x = "Hello world";
            Console.WriteLine(x.GetType());
            x = 10.55f;
            Console.WriteLine(x.GetType());
            x = new Man();
            Console.WriteLine(x.GetType());
        }
    }
}
