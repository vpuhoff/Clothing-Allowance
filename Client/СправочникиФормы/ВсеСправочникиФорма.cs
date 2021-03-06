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
using DevExpress.XtraEditors;

namespace Client.СправочникиФормы
{
    public partial class ВсеСправочникиФорма : DevExpress.XtraEditors.XtraForm
    {
        public ВсеСправочникиФорма()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext

            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext

            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
 
            // This line of code is generated by Data Source Configuration Wizard
           
        }

        private void navigationPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        DatabaseSQLEntities _context;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context = new DatabaseSQLEntities();
            _context.Configuration.LazyLoadingEnabled = true;
            _context.Configuration.ValidateOnSaveEnabled = true;
            _context.Database.BeginTransaction(IsolationLevel.Serializable);
            //navigationPane1.SelectedPageIndex = 0;
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

        private void navigationPane1_SelectedPageChanging(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangingEventArgs e)
        {
            this._context.ChangeTracker.DetectChanges();
           
            if (this._context.ChangeTracker.HasChanges())
            {
                Save();
            }
            if (e.Page.Caption == "Подразделения")
	        {
                _context.Подразделения.Load();
                this.подразделенияBindingSource.DataSource = _context.Подразделения.Local.ToBindingList();
	        }
            if (e.Page.Caption == "Сотрудники")
            {
                _context.Подразделения.Load();
                _context.Звания.Load();
                _context.Сотрудники.Load();
                подразделенияBindingSource.DataSource = _context.Подразделения.Local.ToBindingList();
                званияBindingSource.DataSource = _context.Звания.Local.ToBindingList();
                bindingSource2.DataSource = _context.Сотрудники.Local.ToBindingList();
            }

           
        }

        private void navigationPane1_StateChanged(object sender, DevExpress.XtraBars.Navigation.StateChangedEventArgs e)
        {
            
        }

        private void navigationPane1_Click(object sender, EventArgs e)
        {

        }
    }
}