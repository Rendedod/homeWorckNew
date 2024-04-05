using System;
using System.Collections;
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
    public partial class Screen57 : UserControl
    {
        public Screen57()
        {
            InitializeComponent();
        }

        private void Screen57_Load(object sender, EventArgs e)
        {
            this.Text = "Пример хэш-таблицы";
            // Создаем новую хэш-таблицу:
            var Хэш = new Hashtable();
            // Заполнение хэш-таблицы.
            // Можно добавлять записи "ключ - значение" таким образом:
            Хэш["Украина"] = "Киев";
            // А можно добавлять так:
            Хэш.Add("Россия", "Москва");
            // Здесь государство - это ключ, а столица - это значение
            Хэш.Add("Белоруссия", "Минск");
            // Создаем обычную таблицу (не хэш):
            var Таблица = new DataTable();
            // Задаем схему таблицы, заказывая две колонки:
            Таблица.Columns.Add("ГОСУДАРСТВА");
            Таблица.Columns.Add("СТОЛИЦЫ");
            // В цикле заполняем обычную таблицу парами
            // из хэш-таблицы по рядам:
            foreach (DictionaryEntry ОднаПара in Хэш)
                // Здесь структура DictionaryEntry
                // определяет пару "ключ - значение"
                Таблица.Rows.Add(ОднаПара.Key, ОднаПара.Value);
            // Указываем источник данных для DataGridView:
            dataGridView1.DataSource = Таблица;
        }
    }
}
