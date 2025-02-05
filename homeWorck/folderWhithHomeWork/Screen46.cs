﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homeWorck.folderWhithHomeWorck
{
    public partial class Screen46 : UserControl
    {
        String[] Months;
        int[] Sales;
        Graphics Графика;
        // Далее, создаем объект Bitmap, который имеет
        // тот же размер и разрешение, что и PictureBox
        Bitmap Растр;
        int ОтступСлева, ОтступСправа, ОтступСнизу, ОтступСверху;
        int ДлинаВертОси, ДлинаГоризОси, YГоризОси, Xmax, XНачЭпюры;

        private void button1_Click(object sender, EventArgs e)
        {
            Графика = Graphics.FromImage(Растр);
            РисуемОси();
            РисуемГоризЛинии();
            РисуемВертЛинии();
            РисованиеЭпюры();
            pictureBox1.Image = Растр;
            // Освобождаем ресурсы, используемые объектом класса Graphics:
            Графика.Dispose();
        }

        // Шаг градуировки по горизонтальной и вертикальной осям:
        Double ГоризШаг;
        int ВертШаг;
        int i;
        public Screen46()
        {
            InitializeComponent();
        }

        private void Screen46_Load(object sender, EventArgs e)
        {
            Months = new String[] {"Янв", "Фев", "Март", "Апр", "Май",
"Июнь", "Июль", "Авг", "Сент",
"Окт", "Нояб", "Дек"};
            Sales = new int[] {335, 414, 572, 629, 750, 931,
753, 599, 422, 301, 245, 155};
            ОтступСлева = 35; ОтступСправа = 15;
            ОтступСнизу = 20; ОтступСверху = 10;
            this.Text = " Построение графика ";
            button1.Text = "Нарисовать график";
            this.ClientSize = new Size(593, 319);
            pictureBox1.Size = new Size(569, 242);
            Растр = new Bitmap(pictureBox1.Width,
            pictureBox1.Height,
            pictureBox1.CreateGraphics());
            YГоризОси = pictureBox1.Height - ОтступСнизу;
            Xmax = pictureBox1.Width - ОтступСправа;
            ДлинаГоризОси = pictureBox1.Width -
            (ОтступСлева + ОтступСправа);
            ДлинаВертОси = YГоризОси - ОтступСверху;
            ГоризШаг = Convert.ToDouble(ДлинаГоризОси / Sales.Length);
            ВертШаг = Convert.ToInt32(ДлинаВертОси / 10);
            XНачЭпюры = ОтступСлева + 30;
        }
        void РисуемОси()
        {
            var Перо = new Pen(Color.Black, 2);
            // Рисование вертикальной оси координат:
            Графика.DrawLine(Перо, ОтступСлева, YГоризОси,
            ОтступСлева, ОтступСверху);
            // Рисование горизонтальной оси координат:
            Графика.DrawLine(Перо, ОтступСлева, YГоризОси,
            Xmax, YГоризОси);
            var Шрифт = new Font("Arial", 8);
            for (this.i = 1; i <= 10; i++)
            {
                // Рисуем "усики" на вертикальной координатной оси:
                int Y = YГоризОси - i * ВертШаг;
                Графика.DrawLine(Перо, ОтступСлева - 4, Y, ОтступСлева, Y);
                // Подписываем значения продаж через каждые 100 единиц:
                Графика.DrawString((i * 100).ToString(), Шрифт,
                Brushes.Black, 0, Y - 5);
            } // конец цикла по i
              // Подписываем месяцы на горизонтальной оси:
            for (this.i = 0; i <= Months.Length - 1; i++)
            {
                Графика.DrawString(Months[i], Шрифт, Brushes.Black,
                (int)(ОтступСлева + 18 + i * ГоризШаг), (YГоризОси + 4));
            }
        }
        void РисуемГоризЛинии()
        {
            var ТонкоеПеро = new Pen(Color.LightGray, 1);
            for (this.i = 1; i <= 10; i++)
            {
                // Рисуем горизонтальные почти "прозрачные" линии:
                int Y = YГоризОси - ВертШаг * i;
                Графика.DrawLine(ТонкоеПеро, ОтступСлева + 3, Y, Xmax, Y);
            }
            ТонкоеПеро.Dispose();
        }
        void РисуемВертЛинии()
        {
            // Рисуем вертикальные почти "прозрачные" линии
            var ТонкоеПеро = new Pen(Color.Bisque, 1);
            for (this.i = 0; i <= Months.Length - 1; i++)
            {
                int X = XНачЭпюры + Convert.ToInt32(ГоризШаг * i);
                Графика.DrawLine(ТонкоеПеро, X, ОтступСверху, X, YГоризОси - 4);
            }
            ТонкоеПеро.Dispose();
        }
       
        
        void РисованиеЭпюры()
        {
            var ВертМасштаб = Convert.ToDouble(ДлинаВертОси / 1000.0);
            // или var ВертМасштаб = (Double)ДлинаВертОси / 1000.0;
            // Значения ординат на экране:
            var Y = new int[Sales.Length];
            // Значения абсцисс на экране:
            var X = new int[Sales.Length];
            for (this.i = 0; i <= Sales.Length - 1; i++)
            { // Вычисляем графические координаты точек:
                Y[i] = YГоризОси - Convert.ToInt32(Sales[i] * ВертМасштаб);
                // Отнимаем значения продаж, поскольку ось Y экрана
                // направлена вниз
                X[i] = XНачЭпюры + Convert.ToInt32(ГоризШаг * i);
            }
            // Рисуем первый кружок:
            var Перо = new Pen(Color.Blue, 3);
            Графика.DrawEllipse(Перо, X[0] - 2, Y[0] - 2, 4, 4);
            for (this.i = 0; i <= Sales.Length - 2; i++)
            {
                // Цикл по линиям между точками:
                Графика.DrawLine(Перо, X[i], Y[i], X[i + 1], Y[i + 1]);
                // Отнимаем 2, поскольку диаметр (ширина) точки = 4:
                Графика.DrawEllipse(Перо, X[i + 1] - 2, Y[i + 1] - 2, 4, 4);
            }
        }
    }
}
