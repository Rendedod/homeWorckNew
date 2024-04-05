using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScreen12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Складываю два числа:";
            Console.BackgroundColor = ConsoleColor.Cyan; // - цвет фона
            Console.ForegroundColor = ConsoleColor.Black; // - цвет текста
            Console.Clear();
            Console.WriteLine("Введите первое слагаемое:");
            var Строка = Console.ReadLine();
            // Преобразование строковой переменной в число:
            var X = Single.Parse(Строка);
            // Ввод второго слагаемого:
            Console.WriteLine("Введите второе слагаемое:");
            Строка = Console.ReadLine();
            var Y = Single.Parse(Строка);
            var Z = X + Y;
            Console.WriteLine("Сумма = {0} + {1} = {2}", X, Y, Z);
            // Звуковой сигнал частотой 1000 Гц и длительностью 0.5 секунд:
            Console.Beep(1000, 500);
            // Приостановить выполнение программы до нажатия какой-нибудь
            // клавиши:
            Console.ReadKey();
        }
    }
}
