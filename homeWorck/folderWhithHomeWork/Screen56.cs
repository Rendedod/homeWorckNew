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
    public partial class Screen56 : UserControl
    {
        public Screen56()
        {
            InitializeComponent();
        }

        private void Screen56_Load(object sender, EventArgs e)
        {
            this.Text = "Формирование таблицы";
            String[] Имена = {
            "Андрей - раб", "Света-X", "ЖЭК",
            "Справка по тел", "Ломачинская Светлана", "Мама - дом",
            "Карапузова Таня", "Погода сегодня", "Театр Браво"
            };

            String[] Тлф = {
            "274-88-17", "+38(067)7030356",
            "22-345-72", "009", "223-67-67 доп 32-67", "570-38-76",
            "201-72-23-прямой моб", "001", "216-40-22"
            };

            var Таблица = new DataTable();
            // Заполнение "шапки" таблицы
            Таблица.Columns.Add("ИМЕНА");
            Таблица.Columns.Add("НОМЕРА ТЕЛЕФОНОВ");
            // Заполнение клеток (ячеек) таблицы данных
            for (int i = 0; i <= 8; i++)
                Таблица.Rows.Add(Имена[i], Тлф[i]);
            // Для сетки данных указываем источник данных
            dataGridView1.DataSource = Таблица;
        }
    }
}
