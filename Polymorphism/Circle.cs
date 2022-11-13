using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Circle : Geometry
    {
        public double _radius;

        public Circle ()
        {
            _radius = 7;
        }
        public override double Area()
        {
            double area = (_radius * _radius) * 3.14;
            return area;
        }
    }
}
