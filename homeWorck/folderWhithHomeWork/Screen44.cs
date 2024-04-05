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
    public partial class Screen44 : UserControl
    {
        Boolean Рисовать_ли;
        public Screen44()
        {
            InitializeComponent();
        }

        private void Screen44_Load(object sender, EventArgs e)
        {
            this.Text = "Рисую мышью в форме";
            button1.Text = "Стереть";
            Рисовать_ли = false;
        }

        private void Screen44_MouseDown(object sender, MouseEventArgs e)
        {
            Рисовать_ли = true;
        }

        private void Screen44_MouseUp(object sender, MouseEventArgs e)
        {
            Рисовать_ли = false;
        }

        private void Screen44_MouseMove(object sender, MouseEventArgs e)
        {
            if (Рисовать_ли == true)
            {
                // Рисовать прямоугольник в точке (e.X, e.Y)
                var Графика = CreateGraphics();
                Графика.FillRectangle(new SolidBrush(Color.Red),
                e.X, e.Y, 10, 10);
                // 10x10 пикселов — размер сплошного прямоугольника
                // e.X, e.Y — координаты указателя мыши
                Графика.Dispose(); // Эквиваент C++: delete Графика
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Графика = CreateGraphics();
            Графика.Clear(this.BackColor);
        }
    }
}
