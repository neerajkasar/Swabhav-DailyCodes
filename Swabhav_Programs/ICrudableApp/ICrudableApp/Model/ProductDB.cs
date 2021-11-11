using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICrudableApp.Model
{
    class ProductDB
    {
        public void Create()
        {
            Console.WriteLine("ProductDB created");
        }
        public void Read()
        {
            Console.WriteLine("ProductDB reading");
        }
        public void Update()
        {
            Console.WriteLine("ProductDB Updated");
        }
        public void Delete()
        {
            Console.WriteLine("ProductDB Deleted");
        }

    }
}
