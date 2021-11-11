using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICrudableApp.Model;

namespace ICrudableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PremiumCustomerDB pc = new PremiumCustomerDB();
            OrderDB od = new OrderDB();
            ProductDB pd = new ProductDB();

            Console.WriteLine("Premium Customer");
            pc.Create();
            pc.Read();
            pc.Update();
            pc.Delete();
            Console.WriteLine("Orderdb");
            od.Create();
            od.Read();
            od.Update();
            od.Delete();
            Console.WriteLine("ProductDB");
            pd.Create();
            pd.Read();
            pd.Update();
            pd.Delete();
            Console.ReadLine();
        }
    }
}
