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
    public partial class Screen63 : UserControl
    {
        public Screen63()
        {
            InitializeComponent();

        }

        private void Screen63_Load(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox2.Multiline = true;
            textBox2.ScrollBars = ScrollBars.Vertical;
            webBrowser1.Dock = DockStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // Получаем HTML-код из элемента WebBrowser:
            textBox2.Text = webBrowser1.Document.Body.InnerHtml;
        }
    }
}
