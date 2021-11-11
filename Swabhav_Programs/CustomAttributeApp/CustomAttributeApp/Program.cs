using System;
using System.Collections.Generic;
using System.Reflection;
using CustomAttributeApp;
namespace CustomAttributeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Foo);
            DisplayList(GetMethodsWithAttribute(type));
            Console.ReadLine();
        }
        public static Tuple<List<string>,List<string>> GetMethodsWithAttribute(Type type)
        {
            List<string> methodList = new List<string>();
            List<string> typeList = new List<string>();
            MethodInfo[] methods = type.GetMethods();
            foreach(var method in methods)
            {
                if(method.GetCustomAttribute(typeof(NeedToRefactor)) is NeedToRefactor)
                {
                    methodList.Add(method.Name);
                    typeList.Add(method.ReturnType.ToString().Split('.').Last());
                }
            }
            return Tuple.Create(methodList, typeList);
        }
        public static void DisplayList(Tuple<List<string>,List<string>> stringList)
        {
            Console.WriteLine($"Number of methods with attribute: {stringList.Item1.Count}");
            for (int i = 0; i < stringList.Item1.Count ; i++)
                Console.WriteLine($"{stringList.Item2[i]}{stringList.Item1[i]}");
        }
    }
}

            //var assembly = Assembly.GetExecutingAssembly();
            //var types = assembly.GetTypes();
            //int count = 0;
            //foreach(var type in types)
            //{
            //    var methods = type.GetMethods.where(type => t.GetCustomerAttributes<NeedToRefactor>().Count() > 0);
            //    foreach(var method in methods)
            //    {
            //        count++;
            //        Console.WriteLine("Methods with attribute are : " + method);
            //    }
            //}
            //Console.WriteLine($"There are {count} methods with attribute");