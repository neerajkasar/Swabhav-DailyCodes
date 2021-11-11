using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp.Model
{
    public interface class  Manner
    {
        public  void  Wish()
        {
            Console.WriteLine("wish");
        }
        public void Depart()
        {
            Console.WriteLine("Depart");
        }
    }
}
