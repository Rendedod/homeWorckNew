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
    public partial class Screen42 : UserControl
    {
        public Screen42()
        {
            InitializeComponent();
        }

        private void Screen42_Load(object sender, EventArgs e)
        {
            button1.Text = "Показать дату";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(250, 40);
            // Создаем точечное изображение размером 250 x 40 точек
            // с глубиной цвета 24
            var Рисунок = new Bitmap(250, 40, System.Drawing.
            Imaging.PixelFormat.Format24bppRgb);
            // Создаем новый объект класса Graphics из изображения РАСТР
            var Графика = Graphics.FromImage(Рисунок);
            // Теперь становятся доступными методы класса Graphics!
            // Заливка поверхности цветом формы:
            Графика.Clear(Color.FromName("Control"));
            // Вывод в строку полной даты:
            var Дата = String.Format("Сегодня {0:D}", DateTime.Now);
            Графика.RotateTransform(356.0F);
            // Выводим на изображение текстовую строку Дата,
            // x=5, y=15 - координаты левого верхнего угла строки
            Графика.DrawString(Дата, new Font("Times New Roman", 14,
            FontStyle.Regular), Brushes.Red, 5, 15);
            // Сохраняем изображение в файле risunok.jpg:
            Рисунок.Save("risunok.jpg",System.Drawing.Imaging.ImageFormat.Jpeg);
            // Задаем стиль границ рисунка:
            pictureBox1.BorderStyle = BorderStyle.None; // FixedSingle
                                                        // Загужаем рисунок из файла:
            pictureBox1.Image = Image.FromFile("risunok.jpg");
            // Освобождение ресурсов:
            Рисунок.Dispose(); Графика.Dispose();
        }
    }
}
