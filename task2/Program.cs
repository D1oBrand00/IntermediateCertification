using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Author auth = new Author();
            auth.Name = "Лев Н.Толстой";
            Title tit = new Title();
            tit.Titles = "Война и мир";
            Content cont = new Content();
            cont.Contents = "Русское общество в эпоху войн против Наполеона";
            Book bk = new Book();
            bk.Author = auth;
            bk.Title = tit;
            bk.Content = cont;
            bk.Show();
            Console.ReadKey();
    
        
        
        
    }
    }
}
