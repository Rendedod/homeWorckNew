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
    public partial class Screen47 : UserControl
    {
        public Screen47()
        {
            InitializeComponent();
        }

        private void Screen47_Load(object sender, EventArgs e)
        {
            this.Text = "Введите текст в верхнее поле";
            textBox1.Clear(); textBox2.Clear();
            textBox1.TabIndex = 0;
            button1.Text = "Записать в БО";
            button2.Text = "Извлечь из БО";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText != String.Empty)
            {
                Clipboard.SetDataObject(textBox1.SelectedText);
                textBox2.Text = String.Empty;
            }
            else textBox2.Text = "В верхнем поле текст не выделен";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Объявление объекта-получателя из БО
            var Получатель = Clipboard.GetDataObject();
            // Если данные в БО представлены в текстовом формате...
            if (Получатель.GetDataPresent(DataFormats.Text) == true)
                // то записать их в Text тоже в текстовом формате,
                textBox2.Text = Получатель.
                GetData(DataFormats.Text).ToString();
            else // иначе
                textBox2.Text = "Запишите что-либо в буфер обмена";
        }
    }
}
