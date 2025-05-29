using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Content
    {
        private string content;
        public Content(string content)
        {
            this.content = content;
        }
        public Content() { }
        public void Show()
        {
            Console.WriteLine($"Содержание книги:{content}");
        }
    }
}
