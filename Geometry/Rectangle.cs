using System;

namespace Geometry
{
    public class Rectangle : Shape
    {
        public override string Name => "Rectangle";
        public override double Area => A * A;

        public override int Perimeter => A * 4;
    }
}