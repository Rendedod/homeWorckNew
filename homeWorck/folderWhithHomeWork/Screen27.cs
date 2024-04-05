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
using System.Windows.Shapes;

namespace homeWorck.folderWhithHomeWorck
{
    public partial class Screen27 : UserControl
    {
        String ИмяФайла;
        public Screen27()
        {
            InitializeComponent();
        }

        private void Screen27_Load(object sender, EventArgs e)
        {
            // Установка начальных значений:
            textBox1.Multiline = true; textBox1.Clear();
            textBox1.Size = new Size(268, 112);
            button1.Text = "Открыть"; button1.TabIndex = 0;
            button2.Text = "Сохранить";
            this.Text = "Здесь кодировка Unicode";
            ИмяФайла = @"C:\Ilya\forTest";
            File.CreateText(ИмяФайла + "\\Test.txt" ).Dispose();

            ИмяФайла += "\\Test.txt";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { // Создание объекта StreamReader для чтения из файла:
                var Читатель = new System.IO.StreamReader(ИмяФайла);
                // Непосредственное чтение всего файла в текстовое поле:
                textBox1.Text = Читатель.ReadToEnd();
                Читатель.Close(); // закрытие файла
                                  // Читать текстовый файл в кодировке UNICODE в массив
                                  // строк можно также таким образом (без Open и Close):
                                  // var МассивСтрок = System.IO.File.
                                  // ReadAllLines(@"D:\Text1.txt");
            }
            catch (System.IO.FileNotFoundException Ситуация)
            {
                // Обработка исключительной ситуации:
                MessageBox.Show(Ситуация.Message + "\n" +
                "Нет такого файла", "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
            catch (Exception Ситуация)
            {
                // Отчет о других ошибках:
                MessageBox.Show(Ситуация.Message, "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            { 
                var Писатель = new System.IO.
                StreamWriter(ИмяФайла, false);
                Писатель.Write(textBox1.Text);
                Писатель.Close();
                // Сохранить текстовый файл можно также таким образом
                // (без Close), причем, если файл уже существует,
                // то он будет заменен:
                // System.IO.File.WriteAllText(
                // @"D:\tmp.tmp", textBox1.Text);
            }
            catch (Exception Ситуация)
            {
                // Отчет обо всех возможных ошибках:
                MessageBox.Show(Ситуация.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
