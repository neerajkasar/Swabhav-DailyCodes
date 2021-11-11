using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp.Model
{
    class LineItem
    {
        private int _qty;
        private double _price;
        private String _name;
        private double _total;
        public LineItem (String name, double price, int qty)
        {
            _name = name;
            _price = price;
            _qty = qty;
            _total = _price * _qty;
        }
        public String Name
        {
            get
            {
                return _name;
            }
        }
        public int Qty
        {
            get
            {
                return _qty;
            }
        }
        public double Price
        {
            get
            {
                return _price;
            }
        }
        public double ToltalPrice
        {
            set
            {
                _total = this._price * this._qty;
            }
            get
            {
                return _total;
            }
        }


    }
}
