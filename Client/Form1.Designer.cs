﻿namespace WindowsFormsApplication12
{
    partial class Form1
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.тестовыйЗапросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.получитьДанныеИзБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьДанныеВБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.примерФормыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отзывыИПредложенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ученикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.advDataGridView1 = new Client.AdvDataGridView();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 790);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тестовыйЗапросToolStripMenuItem,
            this.получитьДанныеИзБДToolStripMenuItem,
            this.сохранитьДанныеВБДToolStripMenuItem,
            this.примерФормыToolStripMenuItem,
            this.отзывыИПредложенияToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.formToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1008, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // тестовыйЗапросToolStripMenuItem
            // 
            this.тестовыйЗапросToolStripMenuItem.Name = "тестовыйЗапросToolStripMenuItem";
            this.тестовыйЗапросToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.тестовыйЗапросToolStripMenuItem.Text = "Тестовый запрос";
            this.тестовыйЗапросToolStripMenuItem.Click += new System.EventHandler(this.тестовыйЗапросToolStripMenuItem_Click);
            // 
            // получитьДанныеИзБДToolStripMenuItem
            // 
            this.получитьДанныеИзБДToolStripMenuItem.Name = "получитьДанныеИзБДToolStripMenuItem";
            this.получитьДанныеИзБДToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.получитьДанныеИзБДToolStripMenuItem.Text = "Получить данные из БД";
            this.получитьДанныеИзБДToolStripMenuItem.Click += new System.EventHandler(this.получитьДанныеИзБДToolStripMenuItem_Click);
            // 
            // сохранитьДанныеВБДToolStripMenuItem
            // 
            this.сохранитьДанныеВБДToolStripMenuItem.Name = "сохранитьДанныеВБДToolStripMenuItem";
            this.сохранитьДанныеВБДToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.сохранитьДанныеВБДToolStripMenuItem.Text = "Сохранить данные в БД";
            this.сохранитьДанныеВБДToolStripMenuItem.Click += new System.EventHandler(this.сохранитьДанныеВБДToolStripMenuItem_Click);
            // 
            // примерФормыToolStripMenuItem
            // 
            this.примерФормыToolStripMenuItem.Name = "примерФормыToolStripMenuItem";
            this.примерФормыToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.примерФормыToolStripMenuItem.Text = "Пример формы";
            this.примерФормыToolStripMenuItem.Click += new System.EventHandler(this.примерФормыToolStripMenuItem_Click);
            // 
            // отзывыИПредложенияToolStripMenuItem
            // 
            this.отзывыИПредложенияToolStripMenuItem.Name = "отзывыИПредложенияToolStripMenuItem";
            this.отзывыИПредложенияToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.отзывыИПредложенияToolStripMenuItem.Text = "Отзывы и предложения";
            this.отзывыИПредложенияToolStripMenuItem.Click += new System.EventHandler(this.отзывыИПредложенияToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // formToolStripMenuItem
            // 
            this.formToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ученикиToolStripMenuItem});
            this.formToolStripMenuItem.Name = "formToolStripMenuItem";
            this.formToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.formToolStripMenuItem.Text = "Загрузить таблицу";
            this.formToolStripMenuItem.Click += new System.EventHandler(this.formToolStripMenuItem_Click);
            // 
            // ученикиToolStripMenuItem
            // 
            this.ученикиToolStripMenuItem.Name = "ученикиToolStripMenuItem";
            this.ученикиToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.ученикиToolStripMenuItem.Text = "Ученики";
            this.ученикиToolStripMenuItem.Click += new System.EventHandler(this.ученикиToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(457, 110);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(549, 203);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 22);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(147, 155);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 44);
            this.button2.TabIndex = 10;
            this.button2.Text = "Проверка";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(244, 320);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 309);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(785, 374);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(159, 106);
            this.checkedListBox1.TabIndex = 12;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // advDataGridView1
            // 
            this.advDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advDataGridView1.Location = new System.Drawing.Point(0, 28);
            this.advDataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.advDataGridView1.Name = "advDataGridView1";
            this.advDataGridView1.port = null;
            this.advDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.advDataGridView1.server = null;
            this.advDataGridView1.Size = new System.Drawing.Size(1008, 762);
            this.advDataGridView1.TabIndex = 7;
            this.advDataGridView1.workwithoutserver = true;
            this.advDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.advDataGridView1_CellContentClick);
            this.advDataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.advDataGridView1_CellMouseClick);
            this.advDataGridView1.Click += new System.EventHandler(this.advDataGridView1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1008, 812);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.advDataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "БД Школа - каркас";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem тестовыйЗапросToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem получитьДанныеИзБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьДанныеВБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отзывыИПредложенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private Client.AdvDataGridView advDataGridView1;
        private System.Windows.Forms.ToolStripMenuItem примерФормыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ученикиToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}
