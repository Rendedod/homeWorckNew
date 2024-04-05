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

namespace homeWorck.folderWhithHomeWorck
{
    public partial class Screen41 : UserControl
    {
        public Screen41()
        {
            InitializeComponent();
        }

        private void Screen41_Load(object sender, EventArgs e)
        {
            this.Text = "Печатать";
            button1.Text = "Печать";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                printDocument1.Print();
            }
            catch (Exception Ситуация)
            {
                MessageBox.Show("Ошибка печати на принтере\n",
                Ситуация.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(Image.FromFile(@"C:\myCode\myC#Code\homeWorck\homeWorck\myImg\i_11zon.jpg"),
            e.Graphics.VisibleClipBounds);
            e.HasMorePages = false;
        }
    }
}
