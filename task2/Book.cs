using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Book
    {
        Author author;
        Title title;
        Content content;

        public Author Author { get => author; set => author = value; }
        public Title Title { get => title; set => title = value; }
        public Content Content { get => content; set => content = value; }
        public void Show()
        {
            author.Show();
            title.Show();
            content.Show();
        }
    }
}
