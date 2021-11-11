using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ICrudableApp.Model
{
   abstract class CustomerDB : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("CustomerDB created"); 
        }
          public abstract void Update();
        public void Read()
        {
            Console.WriteLine("CustomerDB Read");
        }
        public abstract void Delete();
    }
}
