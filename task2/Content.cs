using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Content
    {
        string contents;

        public string Contents { get => contents; set => contents = value; }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"Содержание книги: {contents}\n");
            Console.ResetColor();
        }
    }
}
