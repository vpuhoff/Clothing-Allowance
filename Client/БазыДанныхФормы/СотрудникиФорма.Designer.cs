namespace Client.БазыДанныхФормы
{
    partial class СотрудникиФорма
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
            this.сотрудникиDataGridView = new System.Windows.Forms.DataGridView();
            this.Звание = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Подразделение = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.званияBindingSource = new System.Windows.Forms.BindingSource();
            this.подразделенияBindingSource = new System.Windows.Forms.BindingSource();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.званияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.подразделенияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // сотрудникиDataGridView
            // 
            this.сотрудникиDataGridView.AutoGenerateColumns = false;
            this.сотрудникиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.сотрудникиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn9,
            this.Звание,
            this.Подразделение});
            this.сотрудникиDataGridView.DataSource = this.сотрудникиBindingSource;
            this.сотрудникиDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.сотрудникиDataGridView.Location = new System.Drawing.Point(0, 0);
            this.сотрудникиDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.сотрудникиDataGridView.Name = "сотрудникиDataGridView";
            this.сотрудникиDataGridView.RowTemplate.Height = 24;
            this.сотрудникиDataGridView.Size = new System.Drawing.Size(790, 351);
            this.сотрудникиDataGridView.TabIndex = 1;
            this.сотрудникиDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.сотрудникиDataGridView_CellContentClick);
            this.сотрудникиDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.сотрудникиDataGridView_CellEndEdit);
            // 
            // Звание
            // 
            this.Звание.DataPropertyName = "Звание";
            this.Звание.DataSource = this.званияBindingSource;
            this.Звание.DisplayMember = "Звание";
            this.Звание.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Звание.HeaderText = "Звание";
            this.Звание.Name = "Звание";
            this.Звание.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Звание.ValueMember = "Код";
            this.Звание.Width = 120;
            // 
            // Подразделение
            // 
            this.Подразделение.DataPropertyName = "Подразделение";
            this.Подразделение.DataSource = this.подразделенияBindingSource;
            this.Подразделение.DisplayMember = "Наименование";
            this.Подразделение.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Подразделение.HeaderText = "Подразделение";
            this.Подразделение.Name = "Подразделение";
            this.Подразделение.ValueMember = "Код";
            this.Подразделение.Width = 130;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn3.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 54;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Отчество";
            this.dataGridViewTextBoxColumn4.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 79;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Рост";
            this.dataGridViewTextBoxColumn5.HeaderText = "Рост";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Объем_груди";
            this.dataGridViewTextBoxColumn6.HeaderText = "Объем_груди";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Пол";
            this.dataGridViewTextBoxColumn9.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewTextBoxColumn9.HeaderText = "Пол";
            this.dataGridViewTextBoxColumn9.Items.AddRange(new object[] {
            "Муж.",
            "Жен."});
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn9.Width = 50;
            // 
            // званияBindingSource
            // 
            this.званияBindingSource.DataSource = typeof(Client.Звания);
            this.званияBindingSource.CurrentChanged += new System.EventHandler(this.званияBindingSource_CurrentChanged);
            // 
            // подразделенияBindingSource
            // 
            this.подразделенияBindingSource.DataSource = typeof(Client.Подразделения);
            this.подразделенияBindingSource.CurrentChanged += new System.EventHandler(this.подразделенияBindingSource_CurrentChanged);
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataSource = typeof(Client.Сотрудники);
            this.сотрудникиBindingSource.CurrentChanged += new System.EventHandler(this.сотрудникиBindingSource_CurrentChanged);
            // 
            // СотрудникиФорма
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 351);
            this.Controls.Add(this.сотрудникиDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "СотрудникиФорма";
            this.Text = "Сотрудники";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ЗнанияФорма_FormClosing);
            this.Load += new System.EventHandler(this.СотрудникиФорма_Load);
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.званияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.подразделенияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private System.Windows.Forms.DataGridView сотрудникиDataGridView;
        private System.Windows.Forms.BindingSource званияBindingSource;
        private System.Windows.Forms.BindingSource подразделенияBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewComboBoxColumn Звание;
        private System.Windows.Forms.DataGridViewComboBoxColumn Подразделение;


    }
}