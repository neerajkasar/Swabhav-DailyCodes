using System;
using RectangleAbstractionApp.Model;
namespace RectangleAbstractionApp
{
    class RectangleTest
    {
        static void Main(string[] args)
        {
            Rectangle small = new Rectangle();
            Rectangle big = new Rectangle();
            Rectangle temp = small;

            temp.height = 3;
            temp.width = 3; 
            small.height = 2;
            small.width = 2;

            temp.height = temp.height + 7;
            Console.WriteLine(small.GetHashCode());
            Console.WriteLine(temp.GetHashCode());
            Console.ReadLine();

            

        }
    }
}
