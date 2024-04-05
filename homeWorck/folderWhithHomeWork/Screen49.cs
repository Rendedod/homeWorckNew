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
    public partial class Screen49 : UserControl
    {
        public Screen49()
        {
            InitializeComponent();
        }

        private void Screen49_Load(object sender, EventArgs e)
        {
            this.Text = "Имитируем нажатие <Alt>+<PrintScreen>";
            button1.Text = "методом Send класса SendKeys";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendKeys.Send("%{PRTSC}");
        }
    }
}
