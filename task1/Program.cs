using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину стороны A прямоугольника: ");
            double side1 = double.Parse(Console.ReadLine());
            Console.Write("Введите длину стороны B прямоугольника: ");
            double side2 = double.Parse(Console.ReadLine());
            Rectangle rect = new Rectangle(side1, side2);

            Console.WriteLine($"Площадь прямоугольника: {rect.AreaCalculator()}\nПериметр прямоугольника: {rect.PerimeterCalculator()}");
            Console.ReadKey();
        }
    }
}
