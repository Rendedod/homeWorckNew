﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScreen16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Программирование интервалов";
            Console.BackgroundColor = ConsoleColor.Cyan; // - цвет фона
            Console.ForegroundColor = ConsoleColor.Black; // - цвет текста
            Console.Clear();
            Console.WriteLine("Введите сумму за приобретенные товары:");
            Single Сумма, Скидка;
            do // или for (; ; ) - бесконечный цикл
            {
                var Строка = Console.ReadLine();
                // Преобразование строковой переменной в число:
                Сумма = Single.Parse(Строка);
                if (0 < Сумма && Сумма <= 10)
                {
                    // Второй интервал 0 < Сумма <= 10
                    Скидка = 10; // 10%
                }
                else if (10 < Сумма && Сумма <= 20)
                {
                    // Третий интервал 10 < Сумма <= 20
                    Скидка = 20; // 20%
                }
                else if (Сумма > 20)
                {
                    // Четвертый интервал Сумма > 20
                    Скидка = 30; // 30%
                }
                else
                {
                    // Первый интервал Сумма <= 0
                    // Цен <= 0 не существует, поэтому выход из цикла:
                    Console.WriteLine(
                    "Сумма = {0}, поэтому - выход из программы", Сумма);
                    Console.ReadKey();
                    break;
                }
                Console.WriteLine(
                "Сумма = {0}, поэтому скидка = {1}%", Сумма, Скидка);
            } while (true); // конец тела вечного цикла
        }
    }
}
