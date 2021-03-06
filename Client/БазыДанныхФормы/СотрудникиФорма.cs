﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Client.БазыДанныхФормы
{
    public partial class СотрудникиФорма : Form
    {
        DatabaseSQLEntities _context;
        public СотрудникиФорма()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context = new DatabaseSQLEntities();
            _context.Configuration.LazyLoadingEnabled = true;
            _context.Configuration.ValidateOnSaveEnabled = true;
            // Call the Load method to get the data for the given DbSet  
            // from the database.  
            // The data is materialized as entities. The entities are managed by  
            // the DbContext instance.  
            _context.Сотрудники.Load();
            _context.Звания.Load();
            _context.Подразделения.Load();
            this.сотрудникиBindingSource.DataSource =_context.Сотрудники.Local.ToBindingList();
            this.званияBindingSource.DataSource =_context.Звания.Local.ToBindingList();
            this.подразделенияBindingSource.DataSource =_context.Подразделения.Local.ToBindingList();
        }


        void Save()
        {
            this.Validate();
            this._context.SaveChanges();

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this._context.ChangeTracker.DetectChanges();
            if (this._context.ChangeTracker.HasChanges())
            {
                if (MessageBox.Show("Сохранить изменения?", "Есть несохраненные изменения!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    Save();
                }
            }
            this._context.Dispose();
            base.OnFormClosing(e);
        }

        private void ЗнанияФорма_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void СотрудникиФорма_Load(object sender, EventArgs e)
        {

        }

        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this._context.SaveChanges();
            сотрудникиDataGridView.Refresh();
        }

        private void сотрудникиDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void сотрудникиDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void сотрудникиBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void званияBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void подразделенияBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
