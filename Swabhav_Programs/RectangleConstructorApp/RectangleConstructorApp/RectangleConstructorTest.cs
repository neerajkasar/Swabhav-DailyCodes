using System;
using RectangleConstructorApp.Model;

namespace RectangleConstructorApp
{
    class RectangleConstructorTest
    {
        static void Main(string[] args)
        {
            RectangleConstructor rect = new RectangleConstructor(10,20,"Red");

            //rect.setHeight(-1);
            //rect.setWidth(110);

            Console.WriteLine($"Height is {rect.getHeight()} and width is {rect.getWidth()} and color is {rect.getColor()}");
            //Console.WriteLine(rect.CalculateArea());
            
           // Console.WriteLine($"")

            Console.ReadLine();
        }
    }
}
