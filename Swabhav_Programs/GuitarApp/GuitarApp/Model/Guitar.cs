using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Model
{
    class Guitar
    {
        private int _serialNumber;
        private string _builder, _model, _topWood, _backWood, _type;
        double _price;
        public Guitar(int serialNumber, string builder, string model, string topWood, 
            string backWood, double price, string type)
        {
            _serialNumber = serialNumber;
            _backWood = backWood;
            _topWood = topWood;
            _builder = backWood;
            _price = price;
            _type = type;

        }
        public Guitar()
        {

        }
        public int SerialNumber
        {
            get
            {
                return _serialNumber;
            }
        }
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        public string Builder
        {
            get
            {
                return _builder;
            }
            set
            {
                _builder = value;
            }
        }
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }
        public string BackWood
        {
            get
            {
                return _backWood;
            }
            set
            {
                _backWood = value;
            }
        }
        public string TopWood
        {
            get
            {
                return _topWood;
            }
            set
            {
                _topWood = value;
            }
        }
        //public override bool Equals(object obj)
        //{
        //    var guitarObj = (Guitar)obj;
        //    if(_serialNumber == obj.)
        //   // return ;
        //}






    }
}
