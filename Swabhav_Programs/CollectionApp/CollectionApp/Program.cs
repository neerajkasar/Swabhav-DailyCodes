using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionApp.Model;

namespace CollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {

            CaseStudy1();
            Console.WriteLine("Using collections+generic");
            CaseStudy2();
            Console.ReadLine();
        }
        static void CaseStudy1()
        {
            ArrayList basket = new ArrayList();
            basket.Add(new LineItem("earphone", 150, 2));
            basket.Add(new LineItem("kid toys", 500, 3));

            // basket.Add("hello aurionpro");
            try
            {

                foreach (LineItem item in basket)
                {
                    Console.WriteLine($"Name: {item.Name} Price: {item.Price} Quantity: {item.Qty} TotalPrice{item.ToltalPrice}");
                }
            }
            catch (Exception InvalidCastException)
            {
                Console.WriteLine(InvalidCastException);
            }
        }
        static void CaseStudy2()
        {
            List<LineItem> basket = new List<LineItem>();
            basket.Add(new LineItem("earphone", 150, 2));
            basket.Add(new LineItem("kid toys", 500, 3));

            // basket.Add("hello aurionpro");
            try
            {

                foreach (LineItem item in basket)
                {
                    Console.WriteLine($"Name: {item.Name} Price: {item.Price} Quantity: {item.Qty} TotalPrice{item.ToltalPrice}");
                }
            }
            catch (Exception InvalidCastException)
            {
                Console.WriteLine(InvalidCastException);
            }

        } 
    }
}
