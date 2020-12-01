using System;

namespace Geometry
{
    public class Pentagon : Shape
    {
        public override string Name => "Pentagon";
        public override double Area => A * A * Math.Sqrt(25 + 10 * Math.Sqrt(5)) / 4;

        public override int Perimeter => A * 5;
    }
}