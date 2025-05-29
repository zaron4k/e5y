using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("side1");
            double side1 = double.Parse(Console.ReadLine());
            Console.WriteLine("side2");
            double side2 = double.Parse(Console.ReadLine());
            Rectangle rec = new Rectangle(side1, side2);
            Console.WriteLine($"Площадь - {rec.Method1()}");
            Console.WriteLine($"Длина - {rec.Method2()}");
            Console.ReadKey();
        }
    }
}
