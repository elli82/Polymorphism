using System;

namespace Polymorphism  // Elin Linderholm SUT22
{
    class Program
    {
        static void Main(string[] args)
        {
            Geometry square = new Square();
            double areaofSquare = square.Area();

            Geometry circle = new Circle();
            double areaofCircle = circle.Area();

            Geometry rectangle = new Rectangle();
            double areaofRectangle = rectangle.Area();

            Console.WriteLine("Arean av kvadraten är {0}", areaofSquare);
            Console.WriteLine("Arean av cirkeln är {0}", areaofCircle);
            Console.WriteLine("Arean av rektangeln är {0}", areaofRectangle);
        }
    }
}
