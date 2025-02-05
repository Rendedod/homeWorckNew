﻿using System;
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
    public partial class Screen61 : UserControl
    {
        Boolean Цилиндр;
        public Screen61()
        {
            InitializeComponent();
        }

        private void Screen61_Load(object sender, EventArgs e)
        {
            Цилиндр = false;
            this.Text = "Щелкните на графике";
            var Таблица = new DataTable();
            // В этой таблице заказываем две колонки "Месяц" и
            // "Объем продаж":
            Таблица.Columns.Add("Месяц", typeof(String));
            // В VB: Таблица.Columns.Add("Месяц", GetType(String))
            // Значения во второй колонке назначаем типа Long:
            Таблица.Columns.Add("Объем продаж", typeof(long));
            // В VB: Таблица.Columns.Add("Объем продаж", GetType(Long))
            // Заполняем первую строку (ряд) в таблице:
            var Ряд = Таблица.NewRow();
            Ряд["Месяц"] = "Май"; Ряд["Объем продаж"] = 15;
            Таблица.Rows.Add(Ряд);
            // Добавляем вторую строку в таблице:
            Ряд = Таблица.NewRow();
            Ряд["Месяц"] = "Июнь"; Ряд["Объем продаж"] = 35;
            Таблица.Rows.Add(Ряд);
            // Добавляем третью строку:
            Ряд = Таблица.NewRow();
            Ряд["Месяц"] = "Июль"; Ряд["Объем продаж"] = 65;
            Таблица.Rows.Add(Ряд);
            // Добавляем четвертую строку:
            Ряд = Таблица.NewRow();
            Ряд["Месяц"] = "Авг"; Ряд["Объем продаж"] = 85;
            Таблица.Rows.Add(Ряд);
            // Добавляем пятую строку:
            Ряд = Таблица.NewRow();
            Ряд["Месяц"] = "Сент"; Ряд["Объем продаж"] = 71;
            Таблица.Rows.Add(Ряд);
            // Составленную таблицу указываем в качестве источника данных:
            chart1.DataSource = Таблица;
            // На одном графике можно изобразить несколько зависимостей.
            // Например, первая зависимость - объемы продаж по указанным
            // месяцам в 2009 году, и вторая зависимость - продажи по
            // тем же месяцам в 2010 году.
            // В данном графике мы покажем только одну зависимость, данные
            // для отображения этой зависимости назовем "Series1"
            // По горизонтальной оси откладываем названия месяцев:
            chart1.Series["Series1"].XValueMember = "Месяц";
            // А по вертикольной оси откладываем объемы продаж:
            chart1.Series["Series1"].YValueMembers = "Объем продаж";
            // Название графика (диаграммы):
            chart1.Titles.Add("Объемы продаж по месяцам");
            // Задаем тип диаграммы - столбиковая гистограмма:
            chart1.Series["Series1"].ChartType =
            System.Windows.Forms.
            DataVisualization.Charting.SeriesChartType.Column;
            // Тип диаграммы может быыть другим, например: Pie, Line и др.
            chart1.Series["Series1"].Color = Color.Aqua; // то же, что Cyan
                                                         // Легенду на графике не отображаем:
            chart1.Series["Series1"].IsVisibleInLegend = false;
            // Приязка графика к источнику данных:
            chart1.DataBind();
            // Для сетки данных указываем источник данных
            dataGridView1.DataSource = Таблица;
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            Цилиндр = !Цилиндр;
            // Изображение столбиков гистограммы в виде цилиндров:
            if (Цилиндр == true)
                chart1.Series["Series1"]["DrawingStyle"] = "Cylinder";
            else
                chart1.Series["Series1"]["DrawingStyle"] = "Default";
        }
    }
}
