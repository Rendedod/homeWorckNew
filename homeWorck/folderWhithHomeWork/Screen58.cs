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
    public partial class Screen58 : UserControl
    {
        DataTable Таблица;
        DataSet НаборДанных;
        public Screen58()
        {
            InitializeComponent();
        }

        private void Screen58_Load(object sender, EventArgs e)
        {

            string path = $@"C:\Ilya\forTest";
            Directory.CreateDirectory(path);

            this.Text = "Почти табличный редактор";
            button1.Text = "Запись";
            Таблица = new DataTable();
            НаборДанных = new DataSet();
            if (System.IO.File.Exists(@"C:\Ilya\forTest\tabl.xml") == true)
            {
                НаборДанных.ReadXml(@"C:\Ilya\forTest\tabl.xml");
                // Содержимое DataSet в виде строки XML для отладки:
                var СтрокаXML = НаборДанных.GetXml();
                dataGridView1.DataMember = "Название таблицы";
                dataGridView1.DataSource = НаборДанных;
            }
            else
            {
                // Если XML-файла НЕТ:
                dataGridView1.DataSource = Таблица;
                // Заполнение "шапки" таблицы
                Таблица.Columns.Add("ИМЕНА");
                Таблица.Columns.Add("НОМЕРА ТЕЛЕФОНОВ");
                // Добавить объект Таблица в DataSet
                НаборДанных.Tables.Add(Таблица);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Таблица.TableName = "Название таблицы";
            НаборДанных.WriteXml(@"C:\Ilya\forTest\tabl.xml");
        }
    }
}
