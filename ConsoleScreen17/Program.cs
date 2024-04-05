using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScreen17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Использование словаря данных";
            // Создаем словарь данных с полями типа String и int:
            var Месяцы = new Dictionary<String, int>();
            for (int i = 0; i <= 11; i++)
                Месяцы.Add(
                System.Globalization.CultureInfo.CurrentUICulture.
                DateTimeFormat.MonthNames[i],
                DateTime.DaysInMonth(2012, i + 1));
            Console.WriteLine("Месяцы с 30 днями: ");
            Console.WriteLine();
            // Поиск в словаре месяцев, содержащих 30 дней:
            foreach (KeyValuePair<String, int> Месяц in Месяцы)
                if (Месяц.Value == 30)
                    Console.WriteLine("{0} - {1} дней",
                    Месяц.Key, Месяц.Value);
            // Ждем от пользователя нажатия какой-либо клавиши:
            Console.ReadKey();
        }
    }
}
