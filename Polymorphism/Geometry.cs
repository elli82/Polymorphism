using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Geometry
    {
        public double x { get; set; } 

        public virtual double Area()
        {
            double area = x*x;
            return area;
        }
    }
}
