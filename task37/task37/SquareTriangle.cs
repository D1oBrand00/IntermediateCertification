using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task37
{
    static class SquareTriangle
    {
        public static double S(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            if (a < b + c && b < a + c && c < a + b)
            {
                return Math.Sqrt(p * (p - a) * p * (p - b) * p * (p - c));
            }
            else { return 0; }
        }
    }
}
