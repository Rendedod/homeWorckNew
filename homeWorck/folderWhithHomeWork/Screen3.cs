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
    public partial class Screen3 : UserControl
    {
        public Screen3()
        {
            InitializeComponent();
        }

        private void Screen3_Load(object sender, EventArgs e)
        {
            this.Text = "Средство выбора даты";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "ddd, dd MMM, yyyy";
            button1.Text = "Выбрать дату:";
            label1.Text = String.Format(
            "Сегодня: {0}", dateTimePicker1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Focus();
            SendKeys.Send("{F4}");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = String.Format("Выбранная дата: {0}", dateTimePicker1.Text);
        }
    }
}
