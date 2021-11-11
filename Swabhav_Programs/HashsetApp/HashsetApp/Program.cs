using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HashsetApp.Model;

namespace HashsetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // CaseStudy1();
            CaseStudy2();
            Console.ReadLine();

        }
        static void CaseStudy1()
        {
            int count = 1;
            HashSet<int> hs = new HashSet<int>();
            hs.Add(2);
            hs.Add(300);
            hs.Add(58);
            hs.Add(53);
            hs.Add(2);
            foreach (int i in hs)
            {
                Console.WriteLine(count + " " + i);
                count++;
            }
            Console.WriteLine("size: " + hs.Count);

        }
        static void CaseStudy2()
        {
            Student student1 = new Student(100, "Neeraj", "Pune");
            Student student2 = new Student(100, "Neeraj", "Pune");
            Student student3 = new Student(100, "Neeraj", "Pune");
            HashSet<Student> hs = new HashSet<Student>();
            Console.WriteLine(student1.GetHashCode());
            Console.WriteLine(student2.GetHashCode());
            hs.Add(student1);
            hs.Add(student2);
            hs.Add(student3);
            Console.WriteLine(hs.Count);
            
            

            
        }
 
    }
}
