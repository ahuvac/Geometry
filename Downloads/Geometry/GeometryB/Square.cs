using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryA
{
    class Square : IShape
    {
        public Point TopLeft { get; set; }
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }

        public double GetArea()
        {
            return Side * Side;
        }

        public double GetPerimeter()
        {
            return 4 * Side;
        }
    }
}


