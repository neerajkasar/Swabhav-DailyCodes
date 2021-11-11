using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace RectangleEnumApp
{
    class RectangleEnumTest
    {
        static void Main(string[] args)
        {
            RectangleEnum r1 = new RectangleEnum();
            PrintDetails(r1);
            r1.Width = 101;
            r1.Height = 20;
            r1.BorderColor = ColorType.BLUE;
            PrintDetails(r1);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Hi");
            Console.ReadLine();

        }
        static void PrintDetails(RectangleEnum r)
        {
            Console.WriteLine($"Width: {r.Width} Height: {r.Height} BorderColor: {r.BorderColor} Area: {r.CalculateArea()}");
        }
    }
}
