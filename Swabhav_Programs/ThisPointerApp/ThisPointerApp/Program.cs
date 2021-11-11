using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThisPointerApp.Model;

namespace ThisPointerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Player sachin = new Player("Sachin Tendulkar",45);
            PrintDetails(sachin);
            Player virat = new Player("Virat");
            PrintDetails(virat);
            Player elder = sachin.WhoIsElder(virat);
            PrintDetails(elder);
            Console.ReadLine();
        }
        static void PrintDetails(Player p)
        {
            Console.WriteLine($"Name: {p.Name} Age: {p.Age}");
        }
    }
}
