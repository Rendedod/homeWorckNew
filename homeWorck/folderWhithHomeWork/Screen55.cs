using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homeWorck.folderWhithHomeWorck
{
    public partial class Screen55 : UserControl
    {
        public Screen55()
        {
            InitializeComponent();
        }

        private void Screen55_Load(object sender, EventArgs e)
        {
            this.Text = "Таблица в формате HTML";
            String[] Имена = {"Андрей - раб", "Света-X", "ЖЭК",
                "Справка по тел", "Александр Степанович", "Мама - дом",
                "Карапузова Таня", "Погода сегодня", "Театр Браво"
            };
            String[] Тлф = {"274-88-17", "+38(067)7030356",
                "22-345-72", "009", "223-67-67 доп 32-67", "570-38-76",
                "201-72-23-прямой моб", "001", "216-40-22"
            };
            var text = "<title>Пример таблицы</title>" +
            "<table border><caption>" +
            "Таблица телефонов</caption>" + "\r\n";

            for (int i = 0; i <= 8; i++)
                text += String.Format("<tr><td>{0}<td>{1}",
                Имена[i], Тлф[i]) + "\r\n";

            text = text + "</table>";
            // Запись таблицы в текстовый файл D:\Tabl_tel.htm.
            // Создание экземпляра StreamWriter для записи в файл
            string path = @"C:\Ilya\forTest";
            Directory.CreateDirectory(path);
            var Писатель = new System.IO.StreamWriter(@"C:\Ilya\forTest\Tabl_tel.htm", false,
            System.Text.Encoding.GetEncoding(1251));
            // - здесь заказ кодовой страницы Win1251 для русских букв
            Писатель.Write(text); Писатель.Close();
            try
            {
                System.Diagnostics.Process.Start(
                "Opera", @"C:\Ilya\forTest\Tabl_tel.htm");
                // Файл HTM можно открывать также с пом MS_WORD:
                // System.Diagnostics.Process.Start(
                // "WinWord", @"D:\Tabl_tel.htm");
            }
            catch (Exception Ситуация)
            {
                // Отчет об ошибках
                MessageBox.Show(Ситуация.Message, "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Screen55_Load(sender, e);
        }
    }
}
