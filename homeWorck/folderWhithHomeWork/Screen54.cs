using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homeWorck.folderWhithHomeWorck
{
    public partial class Screen54 : UserControl
    {
        System.IO.StringReader Читатель;
        public Screen54()
        {
            InitializeComponent();
        }

        private void Screen54_Load(object sender, EventArgs e)
        {
            const String НС = "\r\n"; // Новая строка
            this.Text = "Формирование таблицы";
            Double[] X = {5342736.17653, 2345.3333, 234683.853749,
                2438454.825368, 3425.72564, 5243.25,
                537407.6236, 6354328.9876, 5342.243
            };
            Double[] Y = {27488.17, 3806703.356, 22345.72,
                54285.34, 2236767.3267, 57038.76,
                201722.3, 26434.001, 2164.022
            };
            // ~ ~ ~ ~ ~ ~ ~ ~ ~ ~
            textBox1.Multiline = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Font = new Font("Courier New", 9.0F);
            textBox1.Text = "КАТАЛОГ КООРДИНАТ" + НС;
            textBox1.Text += "---------------------------------" + НС;
            textBox1.Text += "|Пункт| X | Y |" + НС;
            textBox1.Text += "---------------------------------" + НС;
            // ~ ~ ~ ~ ~ ~ ~ ~ ~ ~
            for (int i = 0; i <= 8; i++)
                textBox1.Text +=
                String.Format("| {0,3:D} | {1,10:F2} | {2,10:F2} |",
                i, X[i], Y[i]) + НС;
            textBox1.Text += "---------------------------------" + НС;
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Создание потока Читатель для чтения из строки:
                Читатель = new System.IO.StringReader(textBox1.Text);
                try
                {
                    printDocument1.Print();
                }
                finally
                {
                    Читатель.Close();
                }
            }
            catch (Exception Ситуация)
            {
                MessageBox.Show(Ситуация.Message);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }
    }
}
