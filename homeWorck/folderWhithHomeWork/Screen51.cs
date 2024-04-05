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
    public partial class Screen51 : UserControl
    {
        long i = 0;
        public Screen51()
        {
            InitializeComponent();
        }

        private void Screen51_Load(object sender, EventArgs e)
        {
            this.Text = "Timer";
            timer1.Interval = 2000;
            timer1.Start();
            listBox1.Items.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            listBox1.Items.Add($"{i}) Прошло 2 секунды.");
        }
    }
}
