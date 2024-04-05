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
    public partial class Screen19 : UserControl
    {
        public Screen19()
        {
            InitializeComponent();
        }

        private void Screen19_Load(object sender, EventArgs e)
        {
            var Кнопка = new Button();
            // Задаем свойства кнопки:
            // Задаем свойства кнопки:
            Кнопка.Visible = true;
            // Ширина и высота кнопки:
            Кнопка.Size = new Size(150, 30);
            // Расположение кнопки в системе координат формы:
            Кнопка.Location = new Point(70, 80);
            Кнопка.Text = "Новая кнопка";
            // Добавление кнопки в коллекцию элементов управления
            this.Controls.Add(Кнопка);
            // Подписку на событие Click для кнопки можно делать "вручную".
            // Связываем событие Click с процедурой обработки этого события:
            Кнопка.Click += new EventHandler(КЛИК);
        }
        private void КЛИК(object sender, EventArgs e)
        {
            MessageBox.Show("Нажата новая кнопка");
        }
    }
}
