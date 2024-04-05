using System;
using System.Drawing;
using System.Windows.Forms;

namespace homeWorck.folderWhithHomeWorck
{
    public partial class Screen5 : UserControl
    {
        public Screen5()
        {
            InitializeComponent();
        }

        private void Screen5_Load(object sender, EventArgs e)
        {
            // Обработка события загрузки формы:
            this.Text = "Введи пароль";
            textBox1.Text = null; textBox1.TabIndex = 0;
            textBox1.PasswordChar = '*';
            textBox1.Font = new Font("Courier New", 10.0F);
            // или textBox1.Font = new Font(
            // FontFamily.GenericMonospace, 10.0F);
            label1.Text = String.Empty;
            label1.Font = new Font("Courier New", 10.0F);
            button1.Text = "Покажи пароль";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }
    }
}
