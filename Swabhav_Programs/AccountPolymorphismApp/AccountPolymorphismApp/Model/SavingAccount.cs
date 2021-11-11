using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Model
{
    class SavingAccount : Account
    {
        public SavingAccount(int accountNo, String name, double balance) : base(accountNo, name, balance)
        {

        }
        private Boolean DoOverDraftCheck()
        {
            if (_balance > 500)
                return true;
            else return false;
        }
       override public void Withdraw(double amt)
        {
            if (DoOverDraftCheck() == true && (_balance - amt) >= 500)
            {
                _balance = _balance - amt;
                Console.WriteLine($"{_balance} withdraw sucessfully!!");
            }
            else Console.WriteLine("Insufficiant Balance...");
        }

    }
}
