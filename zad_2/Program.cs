using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            string str1 = Console.ReadLine();
            str1 = str1.Replace('.', ',');
            double n1 = double.Parse(str1);
            Console.WriteLine("Введите второе число: ");
            string str2 = Console.ReadLine();
            str2 = str2.Replace('.', ',');
            double n2 = double.Parse(str2);
            Console.WriteLine(n2 + " " + n1);
        }
    }
}
