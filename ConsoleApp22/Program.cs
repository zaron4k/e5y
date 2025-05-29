using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите автора книги - ");
            string Titleq = Console.ReadLine();
            Console.WriteLine("Введите имя автора - ");
            string Authorq = Console.ReadLine();
            Console.WriteLine("Введите содержание книги - ");
            string Contentq = Console.ReadLine();

            Title title = new Title(Titleq);
            Author author = new Author(Authorq);
            Content content = new Content(Contentq);
            Console.ForegroundColor = ConsoleColor.Blue;
            Book book = new Book(title, author, content);
            book.Show();
            Console.ResetColor();

            Console.Read();
            
        }
    }
}
