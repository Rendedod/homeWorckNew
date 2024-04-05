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
    public partial class Screen28 : UserControl
    {
        String ИмяФайла;
        public Screen28()
        {
            InitializeComponent();
        }

        private void Screen28_Load(object sender, EventArgs e)
        {
            textBox1.Multiline = true; textBox1.Clear();
            textBox1.Size = new Size(268, 112);
            button1.Text = "Открыть"; button1.TabIndex = 0;
            button2.Text = "Сохранить";
            this.Text = "Здесь кодировка Windows 1251";
            ИмяФайла = @"D:\Text2.txt";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Щелчок на кнопке Открыть
            try
            {
                // Чтобы русские буквы читались бы корректно, объявляем
                // объект Кодировка:
                var Кодировка = System.Text.Encoding.GetEncoding(1251);
                // Создание экземпляра StreamReader для чтения из файла
                var Читатель = new System.IO.
                StreamReader(ИмяФайла, Кодировка);
                textBox1.Text = Читатель.ReadToEnd();
                Читатель.Close();
                // Читать текстовый файл в кодировке Windows 1251 в массив
                // строк можно также таким образом (без Open и Close):
                var МассивСтрок = System.IO.File.
                ReadAllLines(@"D:\Text2.txt", Кодировка);
            }
            catch (System.IO.FileNotFoundException Ситуация)
            {// Обработка исключительной ситуации:
                MessageBox.Show(Ситуация.Message + "\nНет такого файла",
                "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
            catch (Exception Ситуация)
            {
                MessageBox.Show(Ситуация.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Щелчок на кнопке Сохранить:
            try
            {
                var Кодировка =
                System.Text.Encoding.GetEncoding(1251);
                // Создание экземпляра StreamWriter для записи в файл:
                var Писатель = new System.IO.StreamWriter(
                ИмяФайла, false, Кодировка);
                Писатель.Write(textBox1.Text);
                Писатель.Close();
                // Сохранить текстовый файл можно также таким образом (без
                // Close), причем, если файл уже существует, то он будет
                // заменен:
                // System.IO.File.WriteAllText(@"D:\tmp.tmp",
                // textBox1.Text, Кодировка);
            }
            catch (Exception Ситуация)
            {
                // Отчет обо всех возможных ошибках:
                MessageBox.Show(Ситуация.Message, "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
