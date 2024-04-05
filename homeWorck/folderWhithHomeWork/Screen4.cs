using System;
using System.Drawing;
using System.Windows.Forms;

namespace homeWorck.folderWhithHomeWorck
{
    public partial class Screen4 : UserControl
    {
        public Screen4()
        {
            InitializeComponent();
        }

        private void Screen4_Load(object sender, EventArgs e)
        {
            button1.Text = "Извлечь корень";
            label1.Text = String.Empty;
            // или label1.Text = null;
            base.Text = "Извлечение квадратного корня";
            textBox1.Clear(); // Очистка текстового поля
            textBox1.TabIndex = 0; // Установка фокуса в текстовом поле
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Single X; // - из этого числа будем извлекать корень
                      // Преобразование из строковой переменной в Single:
            bool Число_ли = Single.TryParse(
            textBox1.Text,
            System.Globalization.NumberStyles.Number,
            System.Globalization.NumberFormatInfo.CurrentInfo,out X);
            if (Число_ли == false)
            {
                // Если пользователь ввёл не число:
                label1.Text = "Следует вводить числа";
                label1.ForeColor = Color.Red; // - цвет текста на метке
                return; // - выход из процедуры или Return
            }
            // Извлечение корня с преобразованием в тип Single:
            var Y = (Single)Math.Sqrt(X);
            // или var Y = Convert.ToSingle(Math.Sqrt(X));
            label1.ForeColor = Color.Black; // - чёрный цвет текста на метке
            label1.Text = String.Format("Корень из {0} равен {1:F5}", X, Y);
        }
    }
}
