using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x: ");
            string str = Console.ReadLine();
            double x = double.Parse(str);
            double y = Math.Cos(x);
            Console.WriteLine("y = " + y);
        }
    }
}
