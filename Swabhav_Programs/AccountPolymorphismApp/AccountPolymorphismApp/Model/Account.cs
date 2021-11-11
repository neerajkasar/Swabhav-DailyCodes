using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Model
{
  abstract class Account
    {
        private int _accountNo;
         private String _name;
        protected double _balance;
        
        public Account(int accountNo, String name, double balance)
        {
            _name = name;
            _accountNo = accountNo;
            _balance = balance;
        }
        public void Deposite(double balance)
        {
            _balance = _balance + balance;
        }
       public abstract void Withdraw(double amt);
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public int AccountNo
        {
            get
            {
                return _accountNo;
            }
        }
        public double Balance
        {
            get
            {
                return _balance;
            }
        }
    }
}
