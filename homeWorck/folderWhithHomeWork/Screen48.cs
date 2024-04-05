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
    public partial class Screen48 : UserControl
    {
        public Screen48()
        {
            InitializeComponent();
        }

        private void Screen48_Load(object sender, EventArgs e)
        {
            button1.Text = "Извлечь из БО";
            // Размеры графического окна:
            pictureBox1.Size = new Size(184, 142);
            // Записать в PictureBox изображение из файла:
            try
            {
                pictureBox1.Image = Image.FromFile( @"C:\myCode\myC#Code\homeWorck\homeWorck\myImg\poryv.jpg");
            }
            catch (System.IO.FileNotFoundException Ситуация)
            { // Обработка исключительной ситуации:
                MessageBox.Show(
                "Нет такого файла\n" + Ситуация.Message, "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                button1.Enabled = false;
                return;
            }
            Clipboard.SetDataObject(pictureBox1.Image);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Получатель = Clipboard.GetDataObject();
            Bitmap Растр;
            if (Получатель.GetDataPresent(DataFormats.Bitmap) == true)
            {
                // то записать эти данные из БО в переменную
                // Растр в формате Bitmap:
                Растр = (Bitmap)Получатель.GetData(DataFormats.Bitmap);
                pictureBox1.Image = Растр;
            }
        }
    }
}
