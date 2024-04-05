using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homeWorck.folderWhithHomeWorck
{
    public partial class Screen53 : UserControl
    {
        public Screen53()
        {
            InitializeComponent();
        }

        private void Screen53_Load(object sender, EventArgs e)
        {
            const String НС = "\r\n"; // Новая строка
            this.textBox1.Multiline = true;
            this.ClientSize = new Size(400, 300);
            this.textBox1.Size = new Size(400, 300);
            this.Text = "Формирование таблицы";
            String[] Имена = {"Андрей - раб", "Света-X", "ЖЭК",
                    "Справка по тел", "Александр Степанович",
                    "Мама - дом", "Карапузова Таня",
                    "Погода сегодня", "Театр Браво"};
            String[] Тлф = {"274-88-17", "+38(067)7030356",
                    "22-345-72", "009", "223-67-67 доп 32-67",
                    "570-38-76", "201-72-23-прямой моб",
                    "001", "216-40-22"};
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Font = new Font("Courier New", 9.0F);
            textBox1.Text = "ТАБЛИЦА ТЕЛЕФОНОВ" + НС + НС;
            var i = 0;
            // Считают, что цикл foreach/Next - смотрится читабельнее
            // чем обычный цикл:
            foreach (var Имя in Имена)
            {
                textBox1.Text += String.Format(
                "{0, -21} {1, -21}" + НС, Имя, Тлф[i]);
                i = i + 1;
            }
            // Или формирование таблицы с помощью обычного пошагового цикла:
            // for (i = 0; i <= 8; i++)
            // textBox1.Text += String.Format(
            // "{0, -21} {1, -21}", Имена[i], Тлф[i]) + НС;
            textBox1.Text += НС + "ПРИМЕЧАНИЕ:" +
            НС + "для корректного отображения таблицы" + НС + 
            "в Блокноте укажите шрифт Courier New";
            // Запись таблицы в текстовый файл D:\Table.txt.
            // Создание экземпляра StreamWriter для записи в файл
            string path = $@"C:\Ilya\forTest";
            Directory.CreateDirectory(path);
            var Писатель = new System.IO.
            StreamWriter(@"C:\Ilya\forTest\Table.txt", false,
            System.Text.Encoding.GetEncoding(1251));
            // - здесь заказ кодовой страницы Win1251 для русских букв
            Писатель.Write(textBox1.Text);
            Писатель.Close();
        }

        private void показатьТаблицуВБлокнотеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(
                "Notepad", @"C:\Ilya\forTest\Table.txt");
            }
            catch (Exception Ситуация)
            {
                MessageBox.Show(Ситуация.Message, "Ошибка",  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void выходToolStripMenuItem_Click(
        Object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }
    }
}
