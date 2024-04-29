using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Point
    {
        int x;
        int y;
        string stroka;
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public string Stroka { get => stroka; set => stroka = value; }
        public Point() { }
        public Point(int x, int y, string stroka)
        {
            this.x = x;
            this.y = y;
            this.stroka = stroka;
        }

        
    }
}
