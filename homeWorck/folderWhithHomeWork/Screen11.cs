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
    public partial class Screen11 : UserControl
    {
        public Screen11()
        {
            InitializeComponent();
        }

        private void Screen11_Load(object sender, EventArgs e)
        {
            this.Font = new Font("Times New Roman", 12.0F);
            this.Text = "Греческие буквы"; button1.Text = "Вычислить";
            // бета = 2 х Пи х R
            label1.Text = String.Format("Найдем длину окружности: \n" +
            " {0} = 2{1}{2}{1}R, \n" + "где {2} = {3}",
            Convert.ToChar(0x3B2), Convert.ToChar(0x2219),
            Convert.ToChar(0x3C0), Math.PI);
            // Здесь: 0=бета, 1 - точка, 2 - Пи, 3 - число Пи
            label2.Text = "Введите радиус R:";
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Single R; // - радиус
            var Число_ли = Single.TryParse(textBox1.Text,
            System.Globalization.NumberStyles.Number,
            System.Globalization.NumberFormatInfo.CurrentInfo,
            out R);
            if (Число_ли == false)
            {
                MessageBox.Show("Следует вводить числа!", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // - если ошибка, то выход из процедуры
            }
            var beta = 2 * Math.PI * R;
            // 0x3B2 - греческая буква бета
            MessageBox.Show(String.Format("Длина окружности {0} = {1:F4}",
            Convert.ToChar(0x3B2), beta), "Греческая буква");
        }
    }
}
