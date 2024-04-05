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
    public partial class Screen45 : UserControl
    {
        PointF[] МассивТочек;
        // Запрещение управлять формой кривой:
        Boolean Управлять;
        public Screen45()
        {
            InitializeComponent();
        }

        private void Screen45_Load(object sender, EventArgs e)
        {
            Управлять = false;
            this.Text = "Управление сплайном Безье";
            // Начальная узловая точка:
            var p0 = new PointF(50, 50);
            // Две контрольные (управляющие) точки, мы их совместили в одну:
            var p1 = new PointF(125, 125);
            var p2 = new PointF(125, 125);
            // Конечная узловая точка:
            var p3 = new PointF(200.0F, 200.0F);
            МассивТочек = new PointF[] { p0, p1, p2, p3 };
        }

        private void Screen45_Paint(object sender, PaintEventArgs e)
        {
            var Графика = e.Graphics;
            var Перо = new Pen(Color.Blue, 3);
            // Рисуем начальную и конечную узловые точки диаметром 4 пикселя:
            Графика.DrawEllipse(Перо,
            МассивТочек[0].X - 2, МассивТочек[0].Y - 2, 4.0F, 4.0F);
            Графика.DrawEllipse(Перо,
            МассивТочек[3].X - 2, МассивТочек[3].Y - 2, 4.0F, 4.0F);
            // Одна управляющая точка в виде прямоугольника красного цвета:
            Перо.Color = Color.Red;
            Графика.DrawRectangle(Перо, МассивТочек[1].X - 2,
            МассивТочек[1].Y - 2, 4.0F, 4.0F);
            Перо.Color = Color.Blue;
            // Рисуем сплайн Безье:
            Графика.DrawBeziers(Перо, МассивТочек);
            // Освобождение ресурсов:
            Графика.Dispose();
        }

        private void Screen45_MouseMove(object sender, MouseEventArgs e)
        {
            if (Math.Abs(e.X - МассивТочек[1].X) < 4 &&
        Math.Abs(e.Y - МассивТочек[1].Y) < 4 && Управлять == true)
            { // и при этом нажата кнопка мыши,
              // то меняем координаты управляющей точки:
                МассивТочек[1].X = e.X;
                МассивТочек[1].Y = e.Y;
                МассивТочек[2].X = e.X;
                МассивТочек[2].Y = e.Y;
                // и обновляем (перерисовываем) форму:
                this.Invalidate();
            }
        }

        private void Screen45_MouseUp(object sender, MouseEventArgs e)
        {
            Управлять = false;
        }

        private void Screen45_MouseDown(object sender, MouseEventArgs e)
        {
            Управлять = true;
        }
    }
}
