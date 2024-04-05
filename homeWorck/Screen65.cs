using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homeWorck
{
    public partial class Screen65 : Form
    {
        public Screen65()
        {
            InitializeComponent();
        }

        private void Screen65_Load(object sender, EventArgs e)
        {
            // Создаем объект для чтения веб-страницы:
            var КЛИЕНТ = new System.Net.WebClient();
            // Если веб-страница записана в кодировке Win1251, то чтобы
            // русские буквы читались корректно, следует объявить
            // объект Кодировка:
            // var Кодировка = System.Text.Encoding.GetEncoding(1251);
            System.IO.Stream ПОТОК;
            String СТРОКА;
            try
            {
                // Попытка открытия веб-ресурса:
                ПОТОК = КЛИЕНТ.OpenRead("http://www.cbr.ru/");
            }
            catch (Exception Ситуация)
            {
                СТРОКА = String.Format("www.cbr.ru" + "\n{0}", Ситуация.Message);
                label1.Text = СТРОКА;
                return;
            }
            // Чтение HTML-разметки веб-страницы в кодировке
            // Unicode (по умолчанию):
            var Читатель = new System.IO.StreamReader(ПОТОК);
            СТРОКА = Читатель.ReadToEnd();




            var i = СТРОКА.IndexOf("Официальный курс Банка России</div>");
            СТРОКА = СТРОКА.Substring(i + 327, 91);

            СТРОКА = String.Format("Курс доллара США на {0:D}: \n{1} за $1 USD", DateTime.Now, СТРОКА.Substring(0, 9));
            ПОТОК.Close();
            // Копируем в текстовую метку найденный курс доллара:
            label1.Text = СТРОКА;
            // В графическом поле отображаем логотип Центрального банка:
            pictureBox1.ImageLocation = "https://toplogos.ru/images/logo-cbr.png";
        }
    }
}
