using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DictionaryApp.Model;

namespace DictionaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy2();
            Console.ReadLine();
        }
        static void CaseStudy1()
        {
            var map = new Dictionary<int, string>();
            map.Add(1, "one");
            //try
            //{
            //    map.Add(1, "one");
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine("Exception caught..."+e);
            //}
            map.Add(2, "two");
            Console.WriteLine("Count: "+map.Count);
            foreach (KeyValuePair<int , string> i in map)
            {
                Console.WriteLine($"Key {i.Key} Value {i.Value}");
            }
        }
        static void CaseStudy2()
        {
            
            var map = new Dictionary<Student, Student>();
            var s1 = new Student(12,10,"Pune");
            var s2 = new Student(10,12,"Pune");
            var s3 = new Student(12,10,"Pune");

            Console.WriteLine("hashcode: "+s1.GetHashCode());
            Console.WriteLine("hashcode: "+s3.GetHashCode());

            map.Add(s1,s1);
            map.Add(s2, s2);
            if (map.ContainsKey(s3) == false)
                map.Add(s3, s3);



            Console.WriteLine("Total Elements: "+map.Count);
        }
        //public override bool Equals(object obj)
        //{
        //    return ;
        //}
    }
    
}
