using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExceptionCallStackApp.Model;

namespace ExceptionCallStackApp.Model
{
    class InsufficiantFundException : Exception
    {
        private string _message;
        public InsufficiantFundException(AccountEncapsulation account, double withdrawAmmount, double min,string name )
            {

            _message = "Transection declined for Account number: " + account
             + "to maintain mininum balance of " + name+" : ";

            }
        public override string Message
        {
            get
            {
                return _message;
            }
        }
    }
}
