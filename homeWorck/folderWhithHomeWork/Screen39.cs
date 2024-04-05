using System;
using System.Drawing;
using System.Windows.Forms;

namespace homeWorck.folderWhithHomeWorck
{
    public partial class Screen39 : UserControl
    {
        public System.Drawing.Color TransparencyKey { get; set; }

        public Screen39()
        {
            InitializeComponent();
        }

        private void Screen39_Paint(object sender, PaintEventArgs e)
        {
            // Событие перерисовки экранной формы:
            this.ClientSize = new Size(240, 200);
            // Устанавливаем вершины треугольника:
            var p1 = new Point(20, 20);
            var p2 = new Point(225, 66);
            var p3 = new Point(80, 185);
            // Инициализируем массив точек:
            Point[] Точки = { p1, p2, p3 };
            // Закрашиваем этот треугольник цветом ControlDark:
            e.Graphics.FillPolygon(new SolidBrush(
            SystemColors.ControlDark), Точки);
            // Цвет ControlDark задаем прозрачным:
            //this.TransparencyKey = SystemColors.ControlDark;
            var цвет = new SolidBrush(Color.Red);
            e.Graphics.FillPolygon(цвет, Точки);
        }
    }
}
