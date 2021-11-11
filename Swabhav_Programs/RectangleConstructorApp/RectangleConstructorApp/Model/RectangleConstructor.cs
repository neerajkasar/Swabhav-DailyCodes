using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleConstructorApp.Model
{
    class RectangleConstructor
    {
        private int _height = 10, _width = 10;
        private int _lower_bound = 1;
        private int _upper_bound = 100;
        private string _color = "Red";
        public RectangleConstructor(int width, int height, String color)
        {
            _width = width;
            _height = height;
            _color = color;
        }
        public RectangleConstructor(String color)
        {
            _color = color;
        }

        public int Validation(int value)
        {
            if (value < _lower_bound)
            {
                value = _lower_bound;
                return value;
            }
            else if (value > _upper_bound)
            {
                value = _upper_bound;
                return value;
            }
            else
                return value;
        }
        public bool ColorValidation(String color)
        {
            color.ToLower();
            if (color == "red" || color == "green" || color == "blue")
            {
                return true;
            }
            else
                return false;
        }
        public String GetColor(String color)
        {
            if (ColorValidation(color) == true)
                return color;
            else
                return _color;
        }

        public int getHeight()
        {
            return _height;
        }
        public void setHeight(int high)
        {
            _height = Validation(high);
        }
        public int getWidth()
        {
            return _width;
        }
        public void setWidth(int wid)
        {
            _width = Validation(wid);
        }
        public int CalculateArea()
        {
            return _height * _width;
        }

    }
}
