using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homeWorck
{
    public partial class Screen40 : Form
    {
        public Screen40()
        {
            InitializeComponent();
        }

        private void Screen40_Load(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            var Перо = new Pen(Color.Red);
            e.Graphics.DrawEllipse(Перо, new Rectangle(200, 250, 300, 200));
        }
    }
}
