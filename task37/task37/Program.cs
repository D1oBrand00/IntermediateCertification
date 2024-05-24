using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task37
{
    class Program
    {
        /// <summary>
        /// Объявление делегата
        /// </summary>
        delegate double Square(double a, double b, double c);
        static void Main(string[] args)
        {
            /// <summary>
            /// Создание объекта делегата
            /// </summary>
            Square del;
            /// <summary>
            /// Присвоение объекту делегата указателя на метод
            /// </summary>
            del = SquareTriangle.S;
            Console.Write("Введите сторону A треугольника ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите сторону B треугольника ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите сторону C треугольника ");
            double c = double.Parse(Console.ReadLine());
            Console.Write($"{del(a, b, c):F2}");
            Console.ReadKey();


        }
    }
}
