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
            Point A = new Point(4, 7, "A");
            Point B = new Point(3, 5, "B");
            Figure fig = new Figure(A, B);
            Console.WriteLine($"{fig.LengthSide(A,B)}");
            Console.ReadKey();
            
        }
    }
}
