using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Figure
    {
        Point[] points;
        public Figure(params Point[] points)
        {
            this.points = points;
        }
        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2));
        }
        public void PerimeterCalculator()
        {
            
            
        }
    }
}
