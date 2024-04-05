namespace homeWorck
{
    partial class Screen31
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьВФорматеRTFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьВФорматеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохрвнитьВФорматеRTFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьВФорматеRTFToolStripMenuItem,
            this.открытьВФорматеToolStripMenuItem,
            this.сохрвнитьВФорматеRTFToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьВФорматеRTFToolStripMenuItem
            // 
            this.открытьВФорматеRTFToolStripMenuItem.Name = "открытьВФорматеRTFToolStripMenuItem";
            this.открытьВФорматеRTFToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.открытьВФорматеRTFToolStripMenuItem.Text = "Открыть в формате RTF";
            // 
            // открытьВФорматеToolStripMenuItem
            // 
            this.открытьВФорматеToolStripMenuItem.Name = "открытьВФорматеToolStripMenuItem";
            this.открытьВФорматеToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.открытьВФорматеToolStripMenuItem.Text = "Открыть В Формате Win1251";
            // 
            // сохрвнитьВФорматеRTFToolStripMenuItem
            // 
            this.сохрвнитьВФорматеRTFToolStripMenuItem.Name = "сохрвнитьВФорматеRTFToolStripMenuItem";
            this.сохрвнитьВФорматеRTFToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.сохрвнитьВФорматеRTFToolStripMenuItem.Text = "Сохранить в формате RTF";
            this.сохрвнитьВФорматеRTFToolStripMenuItem.Click += new System.EventHandler(this.сохрвнитьВФорматеRTFToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(242, 296);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Screen31
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Screen31";
            this.Text = "Screen31";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Screen31_FormClosing);
            this.Load += new System.EventHandler(this.Screen31_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьВФорматеRTFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьВФорматеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохрвнитьВФорматеRTFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}