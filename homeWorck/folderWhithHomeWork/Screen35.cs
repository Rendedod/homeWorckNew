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
    public partial class Screen35 : UserControl
    {
        public Screen35()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            this.Text = "Рисунок";
            // Размеры формы
            this.Width = 240; this.Height = 240;
            // Создаем объект для работы с изображением
            Image Рисунок = (Image)new Bitmap(@"C:\myCode\myC#Code\homeWorck\homeWorck\myImg\i_11zon.jpg");
            // Вывод изображения в форму
            e.Graphics.DrawImage(Рисунок, 5, 5);
        }
    }
}
