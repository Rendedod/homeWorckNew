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
    public partial class Screen26 : UserControl
    {
        public Screen26()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Произошло событие \"щелчок на первой кнопке\"");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.PerformClick();
        }
    }
}
