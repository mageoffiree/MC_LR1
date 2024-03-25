using System.Data;

namespace LR1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            helpProvider1 = new HelpProvider();
            menuStrip1 = new MenuStrip();
            теоретическаяСправкаToolStripMenuItem = new ToolStripMenuItem();
            равновесиеПоНэшуToolStripMenuItem = new ToolStripMenuItem();
            равновесиедрожащейРукиToolStripMenuItem = new ToolStripMenuItem();
            тестВашейЛичностиToolStripMenuItem = new ToolStripMenuItem();
            пройтиToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(253, 54);
            label1.Name = "label1";
            label1.Size = new Size(246, 15);
            label1.TabIndex = 0;
            label1.Text = "Введи размер интересующей вас матрицы:";
            // 
            // button1
            // 
            button1.Location = new Point(146, 50);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Далее";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 54);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 2;
            label2.Text = "(не более чем 5х5)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 90);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 3;
            label3.Text = "Строк";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 118);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 4;
            label4.Text = "Столбцов";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(121, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(121, 110);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(24, 158);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(563, 176);
            dataGridView1.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(34, 363);
            button2.Name = "button2";
            button2.Size = new Size(155, 23);
            button2.TabIndex = 8;
            button2.Text = "Выполнить подсчет ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(225, 363);
            button3.Name = "button3";
            button3.Size = new Size(177, 23);
            button3.TabIndex = 9;
            button3.Text = "Выделить нужные ячейки";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(429, 363);
            button4.Name = "button4";
            button4.Size = new Size(229, 23);
            button4.TabIndex = 10;
            button4.Text = "Заполнить случайнвыми значениями";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(226, 405);
            button5.Name = "button5";
            button5.Size = new Size(176, 23);
            button5.TabIndex = 11;
            button5.Text = "Снять выделение ячейки";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { теоретическаяСправкаToolStripMenuItem, тестВашейЛичностиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // теоретическаяСправкаToolStripMenuItem
            // 
            теоретическаяСправкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { равновесиеПоНэшуToolStripMenuItem, равновесиедрожащейРукиToolStripMenuItem });
            теоретическаяСправкаToolStripMenuItem.Name = "теоретическаяСправкаToolStripMenuItem";
            теоретическаяСправкаToolStripMenuItem.Size = new Size(147, 20);
            теоретическаяСправкаToolStripMenuItem.Text = "Теоретическая справка";
            // 
            // равновесиеПоНэшуToolStripMenuItem
            // 
            равновесиеПоНэшуToolStripMenuItem.Name = "равновесиеПоНэшуToolStripMenuItem";
            равновесиеПоНэшуToolStripMenuItem.Size = new Size(239, 22);
            равновесиеПоНэшуToolStripMenuItem.Text = "Равновесие по Нэшу";
            равновесиеПоНэшуToolStripMenuItem.Click += равновесиеПоНэшуToolStripMenuItem_Click;
            // 
            // равновесиедрожащейРукиToolStripMenuItem
            // 
            равновесиедрожащейРукиToolStripMenuItem.Name = "равновесиедрожащейРукиToolStripMenuItem";
            равновесиедрожащейРукиToolStripMenuItem.Size = new Size(239, 22);
            равновесиедрожащейРукиToolStripMenuItem.Text = "Равновесие \"дрожащей руки\"";
            равновесиедрожащейРукиToolStripMenuItem.Click += равновесиедрожащейРукиToolStripMenuItem_Click;
            // 
            // тестВашейЛичностиToolStripMenuItem
            // 
            тестВашейЛичностиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { пройтиToolStripMenuItem });
            тестВашейЛичностиToolStripMenuItem.Name = "тестВашейЛичностиToolStripMenuItem";
            тестВашейЛичностиToolStripMenuItem.Size = new Size(137, 20);
            тестВашейЛичностиToolStripMenuItem.Text = "Тест вашей личности";
            // 
            // пройтиToolStripMenuItem
            // 
            пройтиToolStripMenuItem.Name = "пройтиToolStripMenuItem";
            пройтиToolStripMenuItem.Size = new Size(180, 22);
            пройтиToolStripMenuItem.Text = "Пройти";
            пройтиToolStripMenuItem.Click += пройтиToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private HelpProvider helpProvider1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem теоретическаяСправкаToolStripMenuItem;
        private ToolStripMenuItem равновесиеПоНэшуToolStripMenuItem;
        private ToolStripMenuItem равновесиедрожащейРукиToolStripMenuItem;
        private ToolStripMenuItem тестВашейЛичностиToolStripMenuItem;
        private ToolStripMenuItem пройтиToolStripMenuItem;
    }
}
