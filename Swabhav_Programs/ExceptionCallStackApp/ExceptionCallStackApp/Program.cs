using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExceptionCallStackApp.Model;

namespace ExceptionCallStackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            Console.ReadLine();
            
            //try
            //{

            //    m1();
            //}
            //catch(Exception e)
            //{
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    Console.WriteLine(e.StackTrace);
            //}
            //Console.WriteLine("end main");
            //Console.ReadLine();
        }
        static void PrintDetails(AccountEncapsulation a)
        {
            Console.WriteLine($"Account No: {a.PrintAccount()} Name: {a.PrintName()} Balance: {a.PrintBal()}");
        }
        static void m1()
        {
            Console.WriteLine("inside m1");
            m2();

        }
        static void m2()
        {
            Console.WriteLine("inside m2");
            m3();
        }
        static void m3()
        {
            throw new Exception("Something went wrong");
        }
        static void CaseStudy1()
        {
            AccountEncapsulation ae = new AccountEncapsulation(101, "Neeraj", 5000);
            try
            {

                ae.Withdraw(6000);
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);

            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Execute not matter exception or what");
                PrintDetails(ae);
            }

        }
        static void CaseStudy2()
        {
            AccountEncapsulation ae = new AccountEncapsulation(101, "Neeraj", 5000);
            try
            {
                ae.diposite(5001);
            }
            catch(InsufficiantFundException ife)
            {
                Console.WriteLine(ife.Message);
            }
           
        }
    }
}
