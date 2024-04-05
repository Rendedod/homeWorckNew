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
    public partial class Screen18 : UserControl
    {
        public Screen18()
        {
            InitializeComponent();
            Text = "Мониторинг движения мыши";
        }

        private void listBox1_MouseLeave(object sender, EventArgs e)
        {
            listBox1.Items.Add("Курсор мыши вышел из области ListBox");
        }

        private void listBox1_MouseEnter(object sender, EventArgs e)
        {
            listBox1.Items.Add("Курсор мыши вошёл в область ListBox");
        }

        private void listBox1_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.Text = String.Format("X = {0} или {1}", Control.MousePosition.X, e.X);
            textBox2.Text = String.Format("Y = {0} или {1}", Control.MousePosition.Y, e.Y);
        }
    }
}
