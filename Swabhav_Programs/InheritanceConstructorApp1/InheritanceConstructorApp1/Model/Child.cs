using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceConstructorApp1.Model;

namespace InheritanceConstructorApp1.Model
{
    class Child:Parent
    {
        public Child() : base()
        {
            Console.WriteLine("Child Created");
        }
    }
}
