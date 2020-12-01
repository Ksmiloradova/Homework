using Newtonsoft.Json;
using System;


namespace Geometry
{
    public abstract class Shape
    {
        public abstract string Name { get; }
        public abstract double Area { get; }
        public abstract int Perimeter { get; }

        public int A;

        public Shape()
        {
            Random random = new Random();
            A = random.Next(1, 101);
        }
    }
}