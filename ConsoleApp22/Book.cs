using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Book
    {
        private Author author;
        private Title title;
        private Content content;
       
        public Book(Title title, Author author, Content content)
        {
            this.title = title;
            this.author = author;
            this.content = content;
        }

        public void Show()
        {
            author.Show();
            title.Show();
            content.Show();
        }
    }
}
