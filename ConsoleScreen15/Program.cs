using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScreen15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String Строка;
            // Бесконечный цикл, пока пользователь не введет именно число:
            for (; ; )
            {
                Строка = Microsoft.VisualBasic.Interaction.
                InputBox("Введите первое число:", "Складываю два числа");
                if (Microsoft.VisualBasic.Information.
                IsNumeric(Строка) == true) break;
            }
            // - преобразование строковой переменной в число:
            Single X = Single.Parse(Строка);
            // Ввод второго числа:
            for (; ; )
            {
                Строка = Microsoft.VisualBasic.Interaction.
                InputBox("Введите второе число:", "Складываю два числа");
                if (Microsoft.VisualBasic.Information.
                IsNumeric(Строка) == true) break;
            }
            Single Y = Single.Parse(Строка);
            Single Z = X + Y;
            Строка = string.Format("Сумма = {0} + {1} = {2}", X, Y, Z);
            // Вывод результата вычислений на экран:
            Microsoft.VisualBasic.Interaction.MsgBox(Строка);
        }
    }
}
