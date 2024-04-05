using System;
using System.Drawing;
using System.Windows.Forms;

namespace homeWorck.folderWhithHomeWorck
{
    public partial class Screen50 : UserControl
    {
        int i;
        public Screen50()
        {
            InitializeComponent();
        }

        private void Screen50_Load(object sender, EventArgs e)
        {
            i = 0;
            button1.Text = "Сохранить";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Получатель = Clipboard.GetDataObject();
            Bitmap Растр;
            // Если данные в буфере обмена представлены в формате Bitmap...
            if (Получатель.GetDataPresent(DataFormats.Bitmap))
            {
                // то записать их из БО в переменную Растр в формате Bitmap
                var Объект = Получатель.GetData(DataFormats.Bitmap);
                Растр = (Bitmap)Объект;
                // Сохранить изображение в файле Clip.bmp
                Растр.Save($@"C:\Ilya\forTest\Clip{i}.BMP");
                // this.Text = "Сохранено в файле D:\Clip.BMP":
                // button1.Text = "Еще записать?";
                MessageBox.Show(
                @"Изображение из БО записано в файл  @C:\Ilya\forTest", "Успех");
            }
            else
                // В БО нет данных в формате изображений
                MessageBox.Show(
                "В буфере обмена нет данных в формате Bitmap",
                "Запишите какое-либо изображение в БО");
            i++;
        }
    }
}
