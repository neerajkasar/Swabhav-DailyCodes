using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using ExceptionCallStackApp.Model;

namespace ExceptionCallStackApp.Model
{
    
    class AccountEncapsulation
    {
        private double _bal;
        private int _accNo;
        private string _name;

        public void diposite(double bal)
        {
            _bal = bal;
        }
        public void Withdraw(double bal)
        {
            const double _minimum = 500.00;
            if (_bal >= 500 && _bal > bal)
            {
                _bal = _bal - bal;
            }
            else
            {
                throw new InsufficiantFundException(this,bal,_minimum,_name);
            }
        }
        public int GetAccountNo (int accNo)
        {
            return _accNo = accNo;
        }
        public double GetBalance(double bal)
        {
            _bal = bal;
            return _bal;
        }
        public string GetName(String name)
        {
            return _name = name;
        }
        public  double PrintBal()
        {
            return _bal;
        }

        public String PrintName()
        {
            return _name;
        }

        public int PrintAccount()
        {
            return _accNo;
        }
        public AccountEncapsulation(int accNo, String name, double bal )
        {
             GetAccountNo(accNo);
            GetName(name);
            GetBalance(bal);
            _accNo = accNo;
        }
       public AccountEncapsulation()
        {

        }
    }
}
