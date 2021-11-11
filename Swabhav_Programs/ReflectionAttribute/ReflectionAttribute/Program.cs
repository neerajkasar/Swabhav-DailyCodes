using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReflectionAttribute.Model;
using System.Reflection;
namespace ReflectionAttribute 
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = Type.GetType("ReflectionAttribute.Model.AnimalAt");
            //ReflectionAt a = new ReflectionAt(Animals.Dog);
            // AnimalAt at = new AnimalAt();
//            PropertyInfo[] properties = t.GetProperties();
            MethodInfo[] mi = t.GetMethods();
            foreach(MethodInfo m in mi)
            {
                if(m.GetCustomAttributes(typeof(ReflectionAt)) is ReflectionAt)
                {
                    Console.WriteLine(m.Attributes);
                }
            } 
            Console.ReadLine();

        }
    }
}
