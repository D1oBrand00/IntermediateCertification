using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Title
    {
        string titles;

        public string Titles { get => titles; set => titles = value; }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"Название книги: {titles}\n");
            Console.ResetColor();
        }
    }
}
