using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryA
{
    public interface IPoint
    {
        double Xcoord();
        double Ycoord();
        void SetCartesian(double x, double y);

        double Rcoord();
        double Theta();
        void SetPolar(double r, double theta);
    }
}
