using System;
using ReflectionAttribute.Model;
using System.Reflection;

namespace ReflectionAttribute.Model
{
    
    class AnimalAt
    {    
        Type AnimalType = Type.GetType("ReflectionAttribute.Model.ReflectionAt");
       [ReflectionAt()]
       public void DogMethod()
        {
            Console.WriteLine("This is dog method");
        }
    }
}
