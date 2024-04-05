using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homeWorck
{
    public partial class Screen39 : Form
    {
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
            this.TransparencyKey = SystemColors.ControlDark;
        }
    }
}
