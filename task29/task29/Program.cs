using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task29
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tovar> stul = new List<Tovar>();
            List<Tovar> stol = new List<Tovar>();
            List<Tovar> krovat = new List<Tovar>();
            Console.Write("Добавить товар:1-stul\n2-stol\n3-krovat\n4-outputstul\n5-outputstol\n6-outputkrovat\n7-fullpricestul\n8fullpricestol\n9-fullpricekrovat");
            int act = int.Parse(Console.ReadLine());
            switch(act)
            {
                case 1:
                    Console.Clear();
                    stul.Add(Tovar.InPut());
                    break;
                case 2:
                    Console.Clear();
                    stol.Add(Tovar.InPut());
                    break;
                case 3:
                    Console.Clear();
                    krovat.Add(Tovar.InPut());
                    break;
                case 4:
                    Console.Clear();
                    foreach (var elem in stul)
                    {
                        elem.OutPut();
                    }
                    break;
                case 5:
                    Console.Clear();
                    foreach (var elem in stol)
                    {
                        elem.OutPut();
                    }
                    break;
                case 6:
                    Console.Clear();
                    foreach (var elem in krovat)
                    {
                        elem.OutPut();
                    }
                    break;
                case 7:
                    Console.Clear();
                    double fullpricestul = 0;
                    foreach (var elem in stul)
                    {
                        fullpricestul += elem.PriceOfTovar();
                    }
                    Console.Write(fullpricestul);
                    break;
                case 9:
                    Console.Clear();
                    double fullpricestol = 0;
                    foreach (var elem in stol)
                    {
                        fullpricestol += elem.PriceOfTovar();
                    }
                    Console.Write(fullpricestol);
                    break;
                case 10:
                    Console.Clear();
                    double fullpricekrovat = 0;
                    foreach (var elem in krovat)
                    {
                        fullpricekrovat += elem.PriceOfTovar();
                    }
                    Console.Write(fullpricekrovat);
                    break;
            }
            
            Console.ReadKey();
        }
    }
}
