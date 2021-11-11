using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountEncapsulationApp.Model;

namespace AccountEncapsulationApp
{
    class AccountEncapsulationTest
    {
        static void Main(string[] args)
        {
            AccountEncapsulation ae1 = new AccountEncapsulation(101, "Neeraj", 1500);
            AccountEncapsulation ae2 = new AccountEncapsulation(102, "Ram", 500);
            AccountEncapsulation ae3 = new AccountEncapsulation(103, "Sham", 500);
            Console.WriteLine($"Name: {ae1.PrintName()} Account No: {ae1.PrintAccount()} Balance: {ae1.PrintBal()}");
            Console.WriteLine("============================================");
            Console.WriteLine($"Name: {ae2.PrintName()} Account No: {ae2.PrintAccount()} Balance: {ae2.PrintBal()}");
            Console.WriteLine("============================================");
            Console.WriteLine($"Name: {ae3.PrintName()} Account No: {ae3.PrintAccount()} Balance: {ae3.PrintBal()}");
            Console.WriteLine("============================================");
            Console.WriteLine("Rich is:");
            AccountEncapsulation max1 = new AccountEncapsulation();
            AccountEncapsulation max2 = new AccountEncapsulation();
            AccountEncapsulation max3 = new AccountEncapsulation();
            Console.WriteLine("============================================");

            if (ae1.PrintBal() > ae2.PrintBal() && ae1.PrintBal() > ae3.PrintBal())
            {
                max1 = ae1;
                Console.WriteLine($"Name: {ae1.PrintName()} Account No: {ae1.PrintAccount()} Balance: {ae1.PrintBal()}");
                if (ae2.PrintBal() > ae3.PrintBal())
                {
                    max2 = ae2;max3 = ae3;
                    Console.WriteLine($"Name: {ae2.PrintName()} Account No: {ae2.PrintAccount()} Balance: {ae2.PrintBal()}");
                    Console.WriteLine($"Name: {ae3.PrintName()} Account No: {ae3.PrintAccount()} Balance: {ae3.PrintBal()}");
                }
                else
                {
                    max2 = ae3;max3 = ae2;

                    Console.WriteLine($"Name: {ae3.PrintName()} Account No: {ae3.PrintAccount()} Balance: {ae3.PrintBal()}");
                    Console.WriteLine($"Name: {ae2.PrintName()} Account No: {ae2.PrintAccount()} Balance: {ae2.PrintBal()}");
                }
            }
            else if (ae2.PrintBal() > ae1.PrintBal() && ae2.PrintBal() > ae3.PrintBal())
            {
                max1 = ae2;
                Console.WriteLine($"Name: {ae2.PrintName()} Account No: {ae2.PrintAccount()} Balance: {ae2.PrintBal()}");
                if (ae1.PrintBal() > ae3.PrintBal())
                {
                    max2 = ae1;max3 = ae3;
                    Console.WriteLine($"Name: {ae1.PrintName()} Account No: {ae1.PrintAccount()} Balance: {ae1.PrintBal()}");
                    Console.WriteLine($"Name: {ae3.PrintName()} Account No: {ae3.PrintAccount()} Balance: {ae3.PrintBal()}");
                }
                else
                {
                    max2 = ae3;max3 = ae1;
                    Console.WriteLine($"Name: {ae3.PrintName()} Account No: {ae3.PrintAccount()} Balance: {ae3.PrintBal()}");
                    Console.WriteLine($"Name: {ae1.PrintName()} Account No: {ae1.PrintAccount()} Balance: {ae1.PrintBal()}");
                }
            }
            else
                //if (ae3.PrintAccount() > ae1.PrintAccount() && ae3.PrintAccount() > ae2.PrintAccount())
            {
                max1 = ae3;
                Console.WriteLine($"Name: {ae3.PrintName()} Account No: {ae3.PrintAccount()} Balance: {ae3.PrintBal()}");
                if(ae1.PrintBal() > ae2.PrintBal())
                {
                    max2 = ae1;max3 = ae2;
                    Console.WriteLine($"Name: {ae1.PrintName()} Account No: {ae1.PrintAccount()} Balance: {ae1.PrintBal()}");
                    Console.WriteLine($"Name: {ae2.PrintName()} Account No: {ae2.PrintAccount()} Balance: {ae2.PrintBal()}");
                }
                else
                {
                    max2 = ae2;max3 = ae1;
                    Console.WriteLine($"Name: {ae2.PrintName()} Account No: {ae2.PrintAccount()} Balance: {ae2.PrintBal()}");
                    Console.WriteLine($"Name: {ae1.PrintName()} Account No: {ae1.PrintAccount()} Balance: {ae1.PrintBal()}");
                }
            }
            Console.WriteLine("============================================");
            Console.WriteLine("Money distrubution: :");
            Distribution(max1, max2, max3);

            //AccountEncapsulation[] a = new AccountEncapsulation[3];
            //for(int i = 0; i<a.Length;i++)
            //       a[i] = new AccountEncapsulation(12, "Neeraj", 1200);

            //PrintDetails(a);
            Console.ReadLine();
        }
        static void PrintDetails(AccountEncapsulation [] a)
            {
            foreach(AccountEncapsulation b in a)
            {             
                Console.WriteLine(b.PrintAccount());               
            }

        }
        static void Distribution(AccountEncapsulation max1,AccountEncapsulation max2,AccountEncapsulation max3)
        {
            double money = (max1.PrintBal() - 500) / 2;
            Console.WriteLine($"Account No: {max1.PrintAccount()} Name: {max1.PrintName()} Account Balance:{max1.PrintBal() - (money * 2)}");
            Console.WriteLine($"Account No: {max2.PrintAccount()} Name: {max2.PrintName()} Account Balance:{max2.PrintBal() + money} ");
            Console.WriteLine($"Account No: {max3.PrintAccount()} Name: {max3.PrintName()} Account Balance:{max3.PrintBal() + money} ");

        }
        static void PrintRich (AccountEncapsulation [] a)
        {
            for(int i = 0; i<a.Length-1; i++)
            {
                if(a[i].PrintAccount() > a[i+1].PrintAccount())
                {
                    Console.WriteLine($"Name {a[i].PrintName()}");
                }
            }
        }
        
    }
}
