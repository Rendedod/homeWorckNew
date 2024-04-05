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
    public partial class Screen38 : UserControl
    {
        public Screen38()
        {
            InitializeComponent();
        }

        private void Screen38_Load(object sender, EventArgs e)
        {
            var ВсеЦвета = Enum.GetNames(typeof(KnownColor));
            // В VB: Dim ВсеЦвета = [Enum].GetNames(GetType(KnownColor))
            listBox1.Items.Clear();
            // В список элементов добавляем имена всех цветов:
            listBox1.Items.AddRange(ВсеЦвета);
            // Сортировать записи в алфавитном порядке
            listBox1.Sorted = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Цвет Transparent является "прозрачным":
            if (listBox1.Text == "Transparent") return;
            this.BackColor = Color.FromName(listBox1.Text);
            this.Text = "Цвет: " + listBox1.Text;
        }
    }
}
