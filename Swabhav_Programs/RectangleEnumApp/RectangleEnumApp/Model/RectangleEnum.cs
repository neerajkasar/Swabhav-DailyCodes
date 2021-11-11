using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEnumApp
{
    class RectangleEnum
    {
        //public enum ColorType
        //{
        //    RED,BLUE,GREEN
        //}

        public ColorType _borderColor;
        private int _width;
        private int _height;
       public RectangleEnum()
        {
            Console.WriteLine("Rectangle created");
            _borderColor = ColorType.RED;
        }
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value < 0)
                    _width = 1;
                else if (value > 100)
                    _width = 100;
                else
                    _width = value;
            }
        }
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value < 0)
                    _height = 1;
                else if (value > 100)
                    _height = 100;
                else
                    _height = value;
            }
        }
            public ColorType BorderColor
            {
                get
                {
                    return _borderColor;
                }
                set
                {
                   _borderColor = value;
                }
            }
            public int CalculateArea()
            {
            return _height * _width;
            }
        
        
    }
}
