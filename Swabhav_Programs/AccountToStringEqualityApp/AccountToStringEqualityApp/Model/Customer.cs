using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AccountToStringEqualityApp.Model
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
        public Customer(String name, int expence, int id)
        {
            _id = id;
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
        public int IDD
        {
            get
            {
                return _id;
            }
        }
        public override string ToString()
        {
            String str = " Name " + this._name + " balance " + Convert.ToString(this._expense);
            return str;
        }
        //public override bool Equals(Obj)
        //{

        //    
        //    return eq;
        //}
        public override bool Equals(object obj)
        {
            bool eq = _id.Equals(Obj.IDD);
            return eq;
        }
    }
}
