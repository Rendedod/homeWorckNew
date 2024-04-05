using System;
using System.Windows.Forms;

namespace homeWorck
{
    public partial class Screen64 : Form
    {
        public Screen64()
        {
            InitializeComponent();
        }
        short i;
        private void Screen64_Load(object sender, EventArgs e)
        {
            var АдресСайта = "http://google.com";
            var ИмяФормы = "f"; // или "p_13838465-searchform"
            var ИмяПоляФормы = "q"; // или "p_13838465-p"
                                    // Загружаем веб-документ в элемент WebBrowser:
            webBrowser1.Navigate(АдресСайта);
            while (webBrowser1.ReadyState !=
            WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(50);
            }
            
            if (webBrowser1.Document == null)
            {
                MessageBox.Show(
                "Возможно, вы не подключены к Интернету", "Ошибка");
                return;
            }
            
            // Свойство DomDocument приводим к указателю IHTMLDocument2:
            var Док = (mshtml.IHTMLDocument2)
            webBrowser1.Document.DomDocument;
            // В этом случае мы получаем доступ к формам веб-страницы
            // по их именам:
            var Форма = (mshtml.HTMLFormElement)
            Док.forms.item(ИмяФормы, null);
            
            if (Форма == null)
            // В VB: If Форма Is Nothing Then...
            {
                MessageBox.Show(String.Format("Форма с " +
                "именем \"{0}\" не найдена", ИмяФормы), "Ошибка");
                return;
            }
            
            // В форме находим нужное поле по его (полю) имени:
            var ТекстовоеПоле = (mshtml.IHTMLInputElement)
            Форма.namedItem(ИмяПоляФормы);
            if (ТекстовоеПоле == null)
            // В VB: If ТекстовоеПоле Is Nothing Then...
            {
                MessageBox.Show(String.Format("Поле формы с " +
                "именем \"{0}\" не найдено ", ИмяПоляФормы), "Ошибка");
                return;
            }
            
            // Заполняем текстовое поле:
            var ТекстЗапроса = "Visual";
            ТекстовоеПоле.value = ТекстЗапроса;
            // "Программно" нажимаем кнопку "Submit":
            Форма.submit();


        }
    }
}


