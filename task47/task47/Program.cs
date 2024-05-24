using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task47
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Zakaz> zk = new List<Zakaz>();
            while(true)
            {
                Console.Write("Добавить объект класса - 1\nВывести объект клаасса - 2\nВыйти из консоли - Escape");
                char action = Console.ReadKey().KeyChar;
                switch (action)
                {
                    case '1':
                        Console.Clear();
                        Console.Write("Введите фамилию: ");
                        string fam = Console.ReadLine();
                        Console.Write("Введите кол-во мест : ");
                        int size = int.Parse(Console.ReadLine());
                        Console.Write("Введите комфорт: ");
                        string comfort = Console.ReadLine();
                        zk.Add(new Zakaz(fam, size, comfort));
                        Console.Clear();
                        break;
                    case '2':
                        Console.Clear();
                        foreach(var elem in zk)
                        {
                            elem.Show();
                        }
                        break;
                    case '\x001B':
                        return;
                    default:
                        Console.Clear();
                        Console.Write($"Неверно введено\n\n");
                        break;

                }    
                

            }    
        }
    }
}
