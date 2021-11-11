using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Model
{
    class Product
    {
        private int _id;
        private float _discountPercent = 0;
        private String _name;
        private double _price;
        private static int _instanceCount = 0;

        public Product(int id, String name, double price, float discount)
        {
            _id = id;
            _name = name;
            _price = price;
            _discountPercent = discount;
            _instanceCount += 1;
        }
        public Product(int id, String name, double price) : this(id, name, price, 22.0f)
        {
            //_id = id;
            //_name = name;
            //_price = price;
            Console.WriteLine("Constructor 1 ");
        }
        public int GetId()
        {
            return _id;
        }
        public String Name()
        {
            return _name;
        }

        public double Price()
        {
            return _price;
        }

        public float DiscountPercent()
        {
            return _discountPercent;
        }
        public int InstanceCount
        {
            get
            {
                return _instanceCount;
            }
        }
        public static int Occurance
        {
            get
            { 
                return _instanceCount;
            }
        }

        //public static int Occurance()
        //{
        //    re
        //}
        ////Product(int id ,String name, double price,float discount)
        //{

        //}
    }
}
