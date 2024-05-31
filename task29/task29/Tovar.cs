
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task29
{
    class Tovar
    {
        string name;
        double price;
        int kvo;
        public string Name { get => name; set => name = value; }
        public double Price { get => price;  set => price = (price > 20) ? 0: value; }
        public int Kvo { get => kvo; set => kvo = (kvo > 10)  ? 0 : value; }
        public Tovar(string name, double price, int kvo)
        {
            Name = name;
            Price = price;
            Kvo = kvo;
        }
        public double PriceOfTovar()
        {
            return kvo * price;
        }
        public void OutPut()
        {
            Console.WriteLine($"{name}\n{price}\n{kvo}\n{PriceOfTovar()}\n\n");
        }
        public static Tovar InPut()
        {
            Console.Write("Введите товар:");
            string name = Console.ReadLine();
            Console.Write("Введите цену товара:");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Введите кол-во товара:");
            int kvo = int.Parse(Console.ReadLine());
            return new Tovar(name, price, kvo);
        }
    }
}
