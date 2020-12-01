using System;

namespace Geometry
{
    public class Hexagon : Shape
    {
        public override string Name => "Hexagon";
        public override double Area => A * A * 3 * Math.Sqrt(3) / 3;

        public override int Perimeter => A * 6;
    }
}