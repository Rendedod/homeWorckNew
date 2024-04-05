using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homeWorck.folderWhithHomeWorck
{
    public partial class Screen37 : UserControl
    {
        public Screen37()
        {
            InitializeComponent();
        }

        private void Screen37_Load(object sender, EventArgs e)
        {
            this.Text = "Выбери графический примитив";
            var Коллекция = new Object[] {
            "Окружность", "Отрезок", "Прямоугольник",
            "Сектор", "Текст", "Эллипс", "Закрашенный сектор"
            };

            listBox1.Items.AddRange(Коллекция);
            Font = new Font("Times New Roman", 12);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Здесь вместо этого события можно было бы обработать
            // также событие listBox1_Click.
            // Создание графического объекта
            var Графика = CreateGraphics();
            // Создание пера для рисования им фигур
            var Перо = new Pen(Color.Red);
            // Создание кисти для "закрашивания" фигур
            var Кисть = new SolidBrush(Color.Red);
            // Очистка области рисования путем ее окрашивания
            // в первоначальный цвет формы
            Графика.Clear(SystemColors.Control);
            // или Графика.Clear(Color.FromName("Control"));
            // или Графика.Clear(ColorTranslator.FromHtml("#F0F0F0"));
            switch (listBox1.SelectedIndex) // Выбор фигуры:
            {
                case 0: // - выбрана окружность:
                    Графика.DrawEllipse(Перо, 50, 50, 150, 150); break;
                case 1: // - выбран отрезок:
                    Графика.DrawLine(Перо, 50, 50, 200, 200); break;
                case 2: // - выбран прямоугольник:
                    Графика.DrawRectangle(Перо, 50, 30, 150, 180); break;
                case 3: // - выбран сектор:
                    Графика.DrawPie(Перо, 40, 50, 200, 200, 180, 225);
                    break;
                case 4: // - выбран текст:
                    Графика.DrawString(
                    "Каждый во что-то верит, но" + "\n" +
                    "жизнь преподносит сюрпризы",
                    Font, Кисть, 10, 100); break;
                case 5: // - выбран эллипс:
                    Графика.DrawEllipse(Перо, 30, 30, 150, 200); break;
                case 6: // - выбран закрашеный сектор:
                    Графика.FillPie(Кисть, 20, 50, 150, 150, 0, 45); break;
            }
            Графика.Dispose();
        }
    }
}
