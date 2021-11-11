using System;
using SampleLibrary;

namespace CalculatorLibraryTest
{
    public class Class1
    {
      
            public static void Main()
            {
                Calculator cal = new Calculator();
                double number1 = 100;
                double number2 = 50;
                double result = cal.Addition(number1, number2);
                Console.Write(number1);
                Console.Write(" + ");
                Console.Write(number2);
                Console.Write(" = ");
                Console.WriteLine(result);
            }
        }
    }
}
