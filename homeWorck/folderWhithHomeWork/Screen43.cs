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
    public partial class Screen43 : UserControl
    {
        Graphics Графика; Single Угол;
        public Screen43()
        {
            InitializeComponent();
        }

        private void Screen43_Load(object sender, EventArgs e)
        {
            this.Text = "Смена изображения";
            button1.Text = "Развернуть";
            Угол = 0.0F;
            panel1.Location = new Point(12, 12);
            panel1.Size = new System.Drawing.Size(240, 200);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.AliceBlue;
            panel1.Cursor = Cursors.Cross;
            // Задаем поверхность для рисования из аргумента события e:
            Графика = e.Graphics;
            // С помощью смещения задаем центр вращения:
            Графика.TranslateTransform(120.0F, 100.0F);
            // Поворот:
            Графика.RotateTransform(Угол);
            // Вывод текстовой строки полужирным и одновременно
            // наклонным шрифтом:
            Графика.DrawString("Весело живём!",
            new Font("Comic Sans MS", 12,
            FontStyle.Bold ^ FontStyle.Italic),
            Brushes.Red, -70, -15);
            // Здесь -70, -15 - координаты левого верхнего угла
            // создаваемого текста
            Графика.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Угол = Угол + 30.0F;
            // Обновить панель рисования:
            panel1.Invalidate();
        }
    }
}
