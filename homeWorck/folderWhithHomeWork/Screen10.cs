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
    public partial class Screen10 : UserControl
    {
        public Screen10()
        {
            InitializeComponent();
        }

        private void Screen10_Load(object sender, EventArgs e)
        {
            this.Text = "Суперкалькулятор"; label1.Text = "Равно: ";
            button1.Text = "Выбери операцию";
            comboBox1.Text = "Выбери операцию";
            // Заполение (инициализация) раскрывающегося списка:
            String[] Операции = {"Прибавить", "Отнять",
"Умножить", "Разделить", "Очистить"};
            comboBox1.Items.AddRange(Операции);
            comboBox1.TabIndex = 2;
            textBox1.Clear(); textBox1.TabIndex = 0;
            textBox2.Clear(); textBox2.TabIndex = 1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "Равно: ";
            // Преобразование из строковой переменной в Single:
            Single X, Y, Z; Z = 0;
            var Число_ли1 = Single.TryParse(textBox1.Text,
            System.Globalization.NumberStyles.Number,
            System.Globalization.NumberFormatInfo.CurrentInfo,
            out X);
            var Число_ли2 = Single.TryParse(textBox2.Text,
            System.Globalization.NumberStyles.Number,
            System.Globalization.NumberFormatInfo.CurrentInfo,
            out Y);
            if (Число_ли1 == false || Число_ли2 == false)
            {
                MessageBox.Show("Следует вводить числа!", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // - если ошибка, то выход из процедуры
            }
            switch (comboBox1.SelectedIndex)
            { // Выбор арифметической операции:
                case 0: // Выбрали "Прибавить":
                    Z = X + Y; break;
                case 1: // Выбрали "Отнять":
                    Z = X - Y; break;
                case 2: // Выбрали "Умножить":
                    Z = X * Y; break;
                case 3: // Выбрали "Разделить":
                    Z = X / Y; break;
                case 4: // Выбрали "Очистить":
                    textBox1.Clear(); textBox2.Clear();
                    label1.Text = "Равно: "; return;
            }
            label1.Text = String.Format("Равно: {0:F5}", Z);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.DroppedDown = true;
        }
    }
}
