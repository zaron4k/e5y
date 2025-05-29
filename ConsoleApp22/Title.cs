using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Title
    {
        private string title;
        public Title(string title)
        {
            this.title = title;
        }
        public Title() { }
        public void Show()
        {
            Console.WriteLine($"Название книги: {title}");
        }
    }
}
