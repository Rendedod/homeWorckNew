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
    public partial class Screen62 : UserControl
    {
        public Screen62()
        {
            InitializeComponent();
            // Никакие края (из четырёх) не привязаны к экранной форме:
            webBrowser1.Dock = DockStyle.None;
            var СтрокаHTML = "Какой-либо текст до таблицы" +
            "<table border> " +
            "<caption>Таблица телефонов</caption> " +
            "<tr><td>Андрей — раб<td>274-88-17 " +
            "<tr><td>Света-X<td>+38(067)7030356 " +
            "<tr><td>ЖЭК<td>22-345-72 " +
            "<tr><td>Справка по тел<td>009 " +
            "</table> " +
            "Какой-либо текст после таблицы";
            webBrowser1.Navigate("about:" + СтрокаHTML);
        }
    }
}
