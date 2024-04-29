using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Author
    {
        string name;

        public string Name { get => name; set => name = value; }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"Имя автора книги: {name}\n");
            Console.ResetColor();
        }
    }
}
