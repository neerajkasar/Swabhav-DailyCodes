using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICrudableApp.Model
{
    class PremiumCustomerDB:CustomerDB
    {
        public override void Delete()
        {
            Console.WriteLine("Customer Deleted");
        }
        public override void Update()
        {
            Console.WriteLine("CustomerDB updated");
        }
    }
}
