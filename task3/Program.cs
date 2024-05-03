using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(3, 5, "A");
            Point B = new Point(4, 7, "B");
            Point C = new Point(2, 1, "B");
            Point D = new Point(5, 4, "B");
            Point[] ps = new Point[] { A, B,C,D };
            Figure fig = new Figure(ps);
            fig.Output();
            Console.ReadKey();

        }
        
    }
}
