using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Author
    {
        private string author;
        public Author(string author)
        {
            this.author = author;
        }
        public Author() { }
        public void Show()
        {
            Console.WriteLine($"Автор книги:{author}");
        }
    }
}
