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
    public partial class Screen23 : UserControl
    {
        public Screen23()
        {
            InitializeComponent();
        }

        private void Screen23_Load(object sender, EventArgs e)
        {
            // Устанавливаем шрифт с фиксированной шириной (моноширный):
            this.Font = new Font(FontFamily.GenericMonospace, 14.0F);
            // Поскольку мы задали этот шрифт увеличинным (от 8 по умолчанию
            // до 14), форма окажется пропорционально увеличенной
            this.Text = "Какие клавиши нажаты сейчас:";
            label1.Text = String.Empty; label2.Text = String.Empty;
        }

        private void Screen23_KeyPress(object sender, KeyPressEventArgs e)
        {
            label1.Text = "Нажатая клавиша: " + e.KeyChar;
        }

        private void Screen23_KeyDown(object sender, KeyEventArgs e)
        {
            label2.Text = String.Empty;
            // Если нажата клавиша <Alt>
            if (e.Alt == true) label2.Text += "Alt: Yes\n";
            else label2.Text += "Alt: No\n";
            // Если нажата клавиша <Shift>
            if (e.Shift == true) label2.Text += "Shift: Yes\n";
            else label2.Text += "Shift: No\n";
            // Если нажата клавиша <Ctrl>
            if (e.Control == true) label2.Text += "Ctrl: Yes\n";
            else label2.Text += "Ctrl: No\n";
            label2.Text += String.Format(
            "Код клавиши: {0} \nKeyData: {1} \nKeyValue: {2}",
            e.KeyCode, e.KeyData, e.KeyValue);
        }

        private void Screen23_KeyUp(object sender, KeyEventArgs e)
        {
            // Очистка меток при освобождении клавиши
            label1.Text = String.Empty; label2.Text = String.Empty;
        }
    }
}
