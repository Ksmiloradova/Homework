using System;

namespace Geometry
{
    public class Triangle : Shape
    {
        public override string Name => "Triangle";
        public override double Area => Math.Sqrt(A * A * Math.Sqrt(3) / 4);

        public override int Perimeter => A * 3;
    }
}