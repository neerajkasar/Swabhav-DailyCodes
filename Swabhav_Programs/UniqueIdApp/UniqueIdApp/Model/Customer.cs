using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace UniqueIdApp.Model
{
    class Customer
    {
        Type _variable, _property , _function ;
        private static int _id = 100;
        private string _name;
        private int _expense;
        public Customer(String name, int expence)
        {
            _id = _id + 1;
            _expense = expence;
            _name = name;
        }
        public String Name
        {
            get
            {
                return _name;
            }
        }
        public int Expense
        {
            get
            {
                return _expense;
            }
        }
        public static int Id
        {
            get
            {
                return _id;
            }
        }
    }
}
