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
            
            Console.Write("Введите кол-во точек");
            int count = int.Parse(Console.ReadLine());
            Point[] ps = new Point[count] ;
            for (int i = 0; i < count-1;i++)
            {
                Console.Write("Введите данные точки X:");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Введите данные точки Y:");
                int y = int.Parse(Console.ReadLine());
                Console.Write("Введите название точки");
                string n = Console.ReadLine();
                ps[i] = new Point(x, y, n);
            }    
            

            Figure fig = new Figure(ps);
            fig.Output();
            Console.ReadKey();

        }
        
    }
}
