using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryA
{
    class Point : IPoint
    {
        private double x;
        private double y;

        public double Xcoord()
        {
            return x;
        }

        public double Ycoord()
        {
            return y;
        }

        public void SetCartesian(double x, double y)
        {
            this.x = x; this.y = y;
        }

        public double Rcoord()
        {
            return Math.Sqrt(x * x + y * y);
        }

        public double Theta()
        {
            return Math.Atan2(y, x);
        }

        public void SetPolar(double r, double theta)
        {
            if (r <= 0.0)
            {
                x = y = 0.0;
            }
            else
            {
                x = r * Math.Cos(theta);
                y = r * Math.Sin(theta);
            }
        }
    }
}

