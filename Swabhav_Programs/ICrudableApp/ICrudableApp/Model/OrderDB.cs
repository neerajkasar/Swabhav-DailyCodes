using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICrudableApp.Model
{
    class OrderDB:ICrudable
    {
        public void Create()
        {
            Console.WriteLine("OrderDB Created");
        }
        public void Read()
        {
            Console.WriteLine("OrderDB Reading");
        }
        public void Update()
        {
            Console.WriteLine("OrderDB Updated");
        }
        public void Delete()
        {
            Console.WriteLine("OrderDB Deleted");
        }
    }
}
