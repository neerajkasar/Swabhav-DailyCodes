using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleAbstractionApp.Model
{
    class Rectangle
    {
        public int height, width;//camel

        public int CalculateArea()
        {
            return height * width;
        }

    }
}
