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
    public partial class Screen36 : UserControl
    {
        public Screen36()
        {
            InitializeComponent();
        }

        private void Screen36_Load(object sender, EventArgs e)
        {
            this.Text = "Cкроллинг";
            // Назначаем размеры панели:
            // panel1.Size = new Size(200, 151);
            // Назначаем имя файла рисунка:
            pictureBox1.Image = Image.FromFile(@"C:\myCode\myC#Code\homeWorck\homeWorck\myImg\i (2)_11zon.jpg");
            // или pictureBox1.Image = new Bitmap(@"D:\Ris.JPG");
            // Размеры PictureBox в точности соответствуют изображению:
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            // Разрешаем прокрутку изображения:
            panel1.AutoScroll = true;
        }
    }
}
