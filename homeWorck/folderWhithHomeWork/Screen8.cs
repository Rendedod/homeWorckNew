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
    public partial class Screen8 : UserControl
    {
        public Screen8()
        {
            InitializeComponent();
            var tabPage3 = new TabPage();
            tabPage3.UseVisualStyleBackColor = true;
            // Добавление третьей вкладки в существующий набор
            // вкладок tabControl1:
            this.tabControl1.Controls.Add(tabPage3);
            // Добавление переключателей 5 и 6 на третью вкладку:
            tabPage3.Controls.Add(this.radioButton5);
            tabPage3.Controls.Add(this.radioButton6);
            // Расположение переключателей 5 и 6:
            this.radioButton5.Location = new Point(20, 15);
            this.radioButton6.Location = new Point(20, 58);
            this.Text = "Какая улыбка Вам ближе";
            // Задаем названия вкладок:
            tabControl1.TabPages[0].Text = "Текст";
            tabControl1.TabPages[1].Text = "Цвет";
            tabControl1.TabPages[2].Text = "Размер";
            // Эта пара переключателей изменяет текст:
            radioButton1.Text =
            "Восхищенная, сочувственная, " + "\n" + "скромно-смущенная";
            radioButton2.Text = "Нежная улыбка, ехидная, бес" +
            "стыжая, " + "\n" + "подленькая, снисходительная";
            // или
            // radioButton2.Text = "Нежная улыбка, бесстыжая," +
            // Environment.NewLine + "подленькая, снисходительная";
            // Эта пара переключателей изменяет цвет текста:
            radioButton3.Text = "Красный";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = radioButton2.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, 11);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, 13);
        }
    }
}
