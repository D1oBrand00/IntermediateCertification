using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Figure
    {
        Point[] ps;
        public Figure(Point[] ps)
        {
            this.ps = ps;

        }
        public double LengthSide(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow((p1.X - p2.X), 2) + Math.Pow((p1.Y - p2.Y), 2));
        }
        public double PerimeterCalculator()
        {
            double perimeter = 0;
            for (int i = 0; i < ps.Length - 1; i++)
            {
                perimeter += LengthSide(ps[i], ps[i + 1]);
            }
            perimeter += LengthSide(ps[0], ps[ps.Length - 1]);
            return perimeter;

        }
        public void Output()
        {
            if (ps.Length == 3)
            { Console.Write($"Геом.фигура: треугольник\nПериметр фигуры: {PerimeterCalculator():F2}"); }
            else if (ps.Length == 4)
            { Console.Write($"Геом.фигура: прямоуголник\nПериметр фигуры: {PerimeterCalculator():F2}"); }
            else if (ps.Length == 5)
            { Console.Write($"Геом.фигура: пятиугольник\nПериметр фигуры: {PerimeterCalculator():F2}"); }
        }
    }
}
