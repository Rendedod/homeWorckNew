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
    public partial class Screen20 : UserControl
    {
        public Screen20()
        {
            InitializeComponent();
        }

        private void Screen20_Load(object sender, EventArgs e)
        {
            base.Text = "Щелкните на кнопке"; 
            label1.Text = null;
            // Связываем события Click от обеих кнопок с одной
            // процедурой Кнопка_Click:
            button1.Click += new EventHandler(КЛИК);
            button2.Click += new EventHandler(КЛИК);
        }
        private void КЛИК(object sender, EventArgs e)
        {
            // Получить текст, отображаемый на кнопке можно таким образом:
            // label1.Text = Convert.ToString(sender);
            // получить текст, отображаемый на кнопке можно таким образом:
            // или
            // label1.Text = ((Button)sender).Text;
            var Кнопка = (Button)sender; 
            label1.Text = "Нажата кнопка " + Кнопка.Text; // или Кнопка.Name
        }
    }
}
