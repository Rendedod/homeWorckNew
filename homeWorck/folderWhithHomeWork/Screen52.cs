using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace homeWorck.folderWhithHomeWorck
{
    public partial class Screen52 : UserControl
    {
        byte i;
        public Screen52()
        {
            InitializeComponent();

            i = 0;
            Text = "Скриншот каждые 5 секунд";
            button1.Text = "Пуск";
            timer1.Enabled = false;
            timer1.Interval = 5000;
        }
        private void Screen52_Load(object sender, EventArgs e)
        {
            i = 0;
            button1.Text = "Пуск";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i > 4)
            {
                timer1.Enabled = false;
                timer1.Stop();
                Parent.Controls.Remove(this);
            }

            Rectangle screenBorder = Screen.GetBounds(Point.Empty);

            using (var myBitmap = new Bitmap(screenBorder.Width, screenBorder.Height))
            {
                using (var myScreen = Graphics.FromImage(myBitmap))
                {
                    myScreen.CopyFromScreen(Point.Empty, Point.Empty, screenBorder.Size);
                }

                string path = $@"C:\Ilya\forTest";
                Directory.CreateDirectory(path);
                myBitmap.Save($@"C:\Ilya\forTest\Pic{i}.BMP", ImageFormat.Bmp);
            }

        }
    }
}
