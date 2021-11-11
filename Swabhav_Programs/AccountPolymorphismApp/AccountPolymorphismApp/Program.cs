using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccountPolymorphismApp.Model;
using System.Threading.Tasks;

namespace AccountPolymorphismApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount acc1 = new SavingAccount(12, "Neeraj", 2000);
            PrintDetails(acc1);

            acc1.Withdraw(499);
            PrintDetails(acc1);

            CurrentAccount acc2 = new CurrentAccount(1, "Jay", 3000);
            PrintDetails(acc2);
            acc2.Withdraw(29999);
            PrintDetails(acc2);
            Console.ReadLine();
        }
        static void PrintDetails(Account a)
        {
            Console.WriteLine($"Name {a.Name} Account No. {a.AccountNo}  Balance {a.Balance}");
        }
    }
}
