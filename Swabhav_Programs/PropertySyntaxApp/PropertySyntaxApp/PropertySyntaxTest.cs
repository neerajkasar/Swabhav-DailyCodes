using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using PropertySyntaxApp.Model;

namespace PropertySyntaxApp
{
    class PropertySyntaxTest
    {
        static void Main(string[] args)
        {
            PropertySyntax ps = new PropertySyntax();
            ps.Bar = 100;
            Console.WriteLine("Bar: "+ps.Bar);
            Console.WriteLine("Baz: "+ps.Baz);
            Console.ReadLine();
        }
    }
}
