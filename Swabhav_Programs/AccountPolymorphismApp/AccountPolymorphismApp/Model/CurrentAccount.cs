using System;
namespace AccountPolymorphismApp.Model
{
    class CurrentAccount : Account
    {
        public CurrentAccount(int accountNo, String name, double balance) : base(accountNo, name, balance)
            {
                base._balance = base._balance + balance;
                
            }

        public override void Withdraw(double amt)
        {
            if (DoOverDraftCheck() == true && (_balance - amt) >= 500)
            {
                _balance = _balance - amt;
                Console.WriteLine("{0} withdraw sucessfully!!"+ _balance);
            }
            else Console.WriteLine("Insufficiant Balance...");
        }
        private Boolean DoOverDraftCheck()
        {
            if (_balance > 500)
                return true;
            else return false;
        }
        
    }
}
