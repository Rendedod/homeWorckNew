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
    public partial class Screen40 : UserControl
    {
        public Screen40()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var Перо = new Pen(Color.Red);
            e.Graphics.DrawEllipse(Перо, new Rectangle(200, 250, 300, 200));
        }

        private void Screen40_Load(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
