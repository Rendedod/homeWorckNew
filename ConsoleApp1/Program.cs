using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string fullString = Console.ReadLine();
    
            Console.Write("\nВведите под строку: ");
            string supportString = Console.ReadLine();

            int i = fullString.IndexOf(supportString);
            Console.Write("Начало под строки: ");
            Console.WriteLine(i);

            fullString = fullString.Substring(i, supportString.Length + 2);
            Console.Write(fullString);


            Console.ReadKey();
        }
    }
}
