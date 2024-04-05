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
    public partial class Screen6 : UserControl
    {
        public Screen6()
        {
            InitializeComponent();
        }

        private void Screen6_Load(object sender, EventArgs e)
        {
            base.Text = "Флажок CheckBox";
            checkBox1.Text = "Полужирный"; checkBox1.Focus();
            label1.Text = "Выбери стиль шрифта";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Font = new Font("Courier New", 14.0F);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Изменение состояния флажка на противоположное
            if (checkBox1.Checked == true) label1.Font =
            new Font("Courier New", 14.0F, FontStyle.Bold);
            if (checkBox1.Checked == false) label1.Font =
            new Font("Courier New", 14.0F, FontStyle.Regular);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font("Courier New", 14.0F,
label1.Font.Style ^ FontStyle.Italic);
        }
    }
}
