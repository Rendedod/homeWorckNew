﻿using System;
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
    public partial class Screen60 : Form
    {
        // Внешние переменные:
        Boolean ПоказатьКлиентов;
        DataSet НаборДанных;
        public Screen60()
        {
            InitializeComponent();
        }

        private void Screen60_Load(object sender, EventArgs e)
        {
            button1.Text = "Переключатель таблиц"; button1.TabIndex = 0;
            this.Text = "Связанные таблицы"; ПоказатьКлиентов = true;
            // Р О Д И Т Е Л Ь С К А Я Т А Б Л И Ц А "К Л И Е Н Т Ы":
            var Таблица = new DataTable("Клиенты");
            // Создаем первый столбец в таблице:
            var Столбец = new DataColumn("Название организации");
            Столбец.ReadOnly = true; // - его нельзя модифицировать
                                     // Значения в каждой строке столбца должны быть уникальными:
            Столбец.Unique = true;
            // Добавляем этот столбец в таблицу:
            Таблица.Columns.Add(Столбец);
            // Добавляем второй и третий столбец в таблицу:
            Таблица.Columns.Add("Контактное лицо");
            Таблица.Columns.Add("Телефон");
            // Создаем набор данных:
            НаборДанных = new DataSet();
            // Добавляем таблицу "Клиенты" в набор данных:
            НаборДанных.Tables.Add(Таблица);
            // Заполняем строки (ряды) в таблице:
            Таблица.Rows.Add(
            "НИИАСС", "Погребицкий Олег", "095 345 22 37");
            Таблица.Rows.Add(
            "КНУБА", "Юрий Александрович", "050 456 21 03");
            Таблица.Rows.Add(
            "МИИГАИК", "Стороженко Светлана", "067 456 56 72");
            // Д О Ч Е Р Н Я Я Т А Б Л И Ц А "З А К А З Ы":
            Таблица = new DataTable("Заказы");
            // Создаем первый столбец в таблице "Заказы":
            var Столбец1 = new DataColumn("Номер заказа");
            Столбец1.DataType = Type.GetType("System.Int32");
            Столбец1.ReadOnly = true; Столбец1.Unique = true;
            Таблица.Columns.Add(Столбец1);
            // Добавляем второй и третий столбец в таблицу:
            Таблица.Columns.Add("Объем заказа");
            Таблица.Columns.Add("Организация-заказчик");
            НаборДанных.Tables.Add(Таблица);
            // Заполняем строки (ряды) в таблице:
            Таблица.Rows.Add(1, "230000", "НИИАСС");
            Таблица.Rows.Add(2, "178900", "КНУБА");
            Таблица.Rows.Add(3, "300000", "НИИАСС");
            Таблица.Rows.Add(4, "345000", "МИИГАИК");
            Таблица.Rows.Add(5, "308000", "КНУБА");
            // С О З Д А Н И Е С В Я З Е Й М Е Ж Д У Т А Б Л И Ц А М И:
            // Связывем одинаковые столбцы в двух таблицах:
            var Родитель = НаборДанных.
            Tables["Клиенты"].Columns["Название организации"];
            var Дочь = НаборДанных.
            Tables["Заказы"].Columns["Организация-заказчик"];
            var Связь1 = new DataRelation(
            "Ссылка на заказы клиента", Родитель, Дочь);
            // В родительской таблице значения в связываемом столбце
            // должны быть уникальными, а в дочерней - нет.
            НаборДанных.Tables["Заказы"].ParentRelations.Add(Связь1);
            // И С Т О Ч Н И К Д А Н Н Ы Х Д Л Я D A T A G R I D:
            dataGrid1.SetDataBinding(НаборДанных, "Клиенты");
            dataGrid1.CaptionText = "Родительская таблица \"Клиенты\"";
            dataGrid1.CaptionFont = new Font("Consolas", 11);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Показываем либо "таблицу Клиенты", либо таблицу "Заказы":
            ПоказатьКлиентов = !ПоказатьКлиентов;
            if (ПоказатьКлиентов == true)
            {
                dataGrid1.SetDataBinding(НаборДанных, "Клиенты");
                dataGrid1.CaptionText =
                "Родительская таблица \"Клиенты\"";
            }
            else
            {
                dataGrid1.SetDataBinding(НаборДанных, "Заказы");
                dataGrid1.CaptionText =
                "Дочерняя таблица \"Заказы\"";
            }
        }
    }
}
