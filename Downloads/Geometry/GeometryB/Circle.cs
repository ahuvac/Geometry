using System;

namespace GeometryA
{
    class Circle : IShape
    {
        public Point Center { get; set; }
        public double Radius { get; set; }

        public Circle(Point center, double radius)
        {
            Point Center = new Point();
            Center.SetCartesian(center.Xcoord(), center.Ycoord());
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
