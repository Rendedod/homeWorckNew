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
    public partial class Screen32 : UserControl
    {
        Double[] X, Y, U, V;
        public Screen32()
        {
            InitializeComponent();
        }

        private void Screen32_Load(object sender, EventArgs e)
        {
            var ВесьТекст = String.Empty;
            try
            {
                var ТекущийКаталог = System.IO.Directory.
                GetCurrentDirectory();
                // Читаем файл в строковую переменную:
                ВесьТекст = System.IO.File.ReadAllText(@"C:\myCode\myC#Code\homeWorck\homeWorck\textFile\Text Document33.txt");
            }
            catch (System.IO.FileNotFoundException Ситуация)
            {
                MessageBox.Show(
                "Нет такого файла" + "\n" + Ситуация.Message,
                "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
            catch (Exception Ситуация)
            {
                // Отчет о других ошибках:
                MessageBox.Show(Ситуация.Message, "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            // Во всем тексте заменяем точки на запятые, то есть
            // можно вводить числа с точкой, а можно с запятой:
            ВесьТекст = ВесьТекст.Replace(".", ",");
            // В качестве сепаратора задаём: знаки табуляции '\t'),
            // перевод каретки '\r', '\n' и пробелы ' ':
            Char[] Сепаратор = { '\t', '\r', '\n', ' ' };
            var Координаты = ВесьТекст.Split(Сепаратор,
StringSplitOptions.RemoveEmptyEntries);
            // Теперь в каждом элементе массива Координаты() содержится
            // одна координата
            var n = Координаты.Length; // - количество элементов массива
            var z = n % 4;
            // % вычисляет остаток от деления целых чисел, в VB: z = n Mod 4
            if (z != 0) MessageBox.Show(
            "Количество исходных данных не кратно четырем");
            // Здесь уже можно определиться с размерностью массивов:
            X = new Double[n / 4]; U = new Double[n / 4];
            Y = new Double[n / 4]; V = new Double[n / 4];
            // Признаки успешного преобразования из строки в число:
            Boolean A, B, C, D;
            var j = 0; // - счет чисел (элементов) в массиве Координаты()
            for (var i = 0; i <= n / 4 - 1; i++)
            { // Преобразование из строки в число:
                A = Double.TryParse(Координаты[j], out X[i]); j = j + 1;
                B = Double.TryParse(Координаты[j], out Y[i]); j = j + 1;
                C = Double.TryParse(Координаты[j], out U[i]); j = j + 1;
                D = Double.TryParse(Координаты[j], out V[i]); j = j + 1;
                // Если хотя бы одно из преобразований
                // метода TryParse ложно, то:
                if ((A && B && C && D) == false)
                    MessageBox.Show(String.Format(
                    "В строке {0} - не числовой ввод !", i + 1),
                    "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            this.Text = String.Format("Кол-во точек = {0};", n / 4);
            textBox1.Multiline = true; textBox1.Clear();
            // В цикле добавляем строку координат в текстовое поле:
            for (var i = 0; i <= n / 4 - 1; i++)
            {
                textBox1.AppendText(String.Format("X = {0,5:F1}; " +
                "Y = {1,5:F1}; U = {2,5:F1}; V = {3,5:F1};" + "\n",
                X[i], Y[i], U[i], V[i]));
                // Использованный формат "{0,5:F1}" означает: взять нулевой
                // выводимый элемент и записать его с выравниванием вправо в
                // следующих пяти позициях в формате с фиксированной точкой
                // и одним десятичным знаком после запятой.
            }
        }
    }
}
