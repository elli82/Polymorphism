using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Rectangle : Geometry 
    {
        public double _base;
        public double _height;

        public Rectangle()
        {
            _base = 3.5;
            _height = 7.5;
        }
        public override double Area()
        {
            double area = _base * _height;
            return area;
        }
    }
}
