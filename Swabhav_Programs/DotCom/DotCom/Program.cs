using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotCom
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,]  ary = new string[7,7];

            ary[1, 3] = "d";
            ary[1, 4] = "o";
            ary[1, 5] = "g";
           
            ary[3, 2] = "c";
            ary[3, 3] = "a";
            ary[3, 4] = "t";
            int hit = 0;
            int guess = 0;
            
            string hits = "";
            Console.WriteLine(hits.Length);
           
            while(hit != 6)
            {
                guess++;
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());
                if(num1 > 6 || num2 > 6)
                {
                    Console.WriteLine("invalid index");
                    continue;
                }
                else if (ary[num1, num2] != null)
                {
                    hit++;
                    Console.WriteLine("Hit");
                    // hits.Substring(ary[num1,num2)) == true;
                     hits.Concat( Convert.ToString(ary[num1, num2]));
                    Console.WriteLine(hits.Length);
                    if(hits.Contains("dog") || hits.Contains("cat"))
                    {
                        Console.WriteLine("You got"+hits);
                    }
                    Console.WriteLine(hits);
                    ary[num1, num2] = "b";
                }
                else Console.WriteLine("Miss");
            }
            Console.WriteLine($"You took "+guess+" guesses to complete");
            Console.ReadLine();
        }
    }
}
