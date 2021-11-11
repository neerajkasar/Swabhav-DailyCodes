using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionGenerationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int fno = Convert.ToInt32(args[0]);
            int sno = Convert.ToInt32(args[1]);
            int result = fno / sno;
            Console.WriteLine("{0} / {1} = {2}",fno,sno,result);
            Console.WriteLine("end of main");
            Console.ReadLine();
        }
    }
}
