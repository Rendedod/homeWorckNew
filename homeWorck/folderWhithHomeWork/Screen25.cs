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
    public partial class Screen25 : UserControl
    {
        String ТчкИлиЗпт;
        public Screen25()
        {
            InitializeComponent();
        }

        private void Screen25_Load(object sender, EventArgs e)
        {
            this.Text = "Введите число";
            // Выясняем, что установлено на данном ПК в качестве
            // разделителя целой и дробной частей: точка или запятая
            ТчкИлиЗпт = System.Globalization.
            NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var ТчкИлиЗптНАЙДЕНА = false;
            // Разрешаю ввод десятичных цифр:
            if (Char.IsDigit(e.KeyChar) == true) return;
            // Разрешаю ввод <Backspace>:
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            // Поиск ТчкИлиЗпт в textBox.
            // Если IndexOf() == -1, то не найдена:
            if (textBox1.Text.IndexOf(ТчкИлиЗпт) != -1)
                ТчкИлиЗптНАЙДЕНА = true;
            // Если ТчкИлиЗпт уже есть в textBox, то запрещаем вводить и ее,
            // и любые другие символы:
            if (ТчкИлиЗптНАЙДЕНА == true) { e.Handled = true; return; }
            // Если ТчкИлиЗпт еще нет в TextBox, то разрешаем ее ввод:
            if (e.KeyChar.ToString() == ТчкИлиЗпт) return;
            // В других случаях - запрет на ввод:
            e.Handled = true;
        }
    }
}
