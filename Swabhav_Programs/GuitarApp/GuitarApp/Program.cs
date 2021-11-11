using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuitarApp.Model;
namespace GuitarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Inventory iv = new Inventory();
            iv.AddGuitar(101, "String builder", "Model12", "topwood12", "backwood12", 1200.99, "type");
            //if(iv.GetGuitar(101) == null)
            //{
            //    Console.WriteLine("Guitar not found");
            //}
            //else
            //{
            //    Console.WriteLine("Guitar" + iv.GetGuitar(101) + "is available");
            //}
            Console.WriteLine(iv.SearchGuitar(101)+"And you have it for price "+);
            
            Console.ReadLine();

        }
    }
}
