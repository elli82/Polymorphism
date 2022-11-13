using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Square : Geometry 
    {
        public double _side;

        public Square()
        {
            _side = 9;
        }
        public override double Area()
        {
            double area = _side * _side;
            return area;
        }
    }
}
