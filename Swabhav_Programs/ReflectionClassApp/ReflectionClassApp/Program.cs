using System;
using System.Reflection;
using ReflectionClassApp.Model;

namespace ReflectionClassApp
{
    class Program
    {
        static void Main(string[] args)
        {
          //  AccountEncapsulation ae = new AccountEncapsulation(101, "Neeraj", 200);
            Type T = Type.GetType("ReflectionClassApp.Model.AccountEncapsulation");
            PropertyInfo[] properties = T.GetProperties();
            MethodInfo[] prop = T.GetMethods();

            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name+" and name is "+property.Name);
            }
            foreach(MethodInfo pro in prop)
            {
                Console.WriteLine(pro.Name);
            }
            Console.ReadLine();
        }
    }
}
