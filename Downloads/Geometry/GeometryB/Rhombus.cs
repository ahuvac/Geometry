using System;
namespace GeometryA
{
    class Rhombus : IShape
    {
        public double p { get; set; }
        public double q { get; set; }
        public double side {get; set;}

        public Rhombus(double diag1, double diag2, double s)
        {
            p = diag1;
            q = diag2;
            side = s;
        }

        public double GetArea()
        {
            return p * q / 2;
        }

        public double GetPerimeter()
        {
            return 4 * side;
        }
    }
}
