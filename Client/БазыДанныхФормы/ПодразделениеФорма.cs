using System;
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
    public partial class ПодразделениеФорма : Form
    {
        
        public ПодразделениеФорма()
        {
            InitializeComponent();
        }
        DatabaseSQLEntities _context;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context = new DatabaseSQLEntities();

            // Call the Load method to get the data for the given DbSet  
            // from the database.  
            // The data is materialized as entities. The entities are managed by  
            // the DbContext instance.  
            _context.Подразделения.Load();

            // Bind the categoryBindingSource.DataSource to  
            // all the Unchanged, Modified and Added Category objects that  
            // are currently tracked by the DbContext. 
            // Note that we need to call ToBindingList() on the  
            // ObservableCollection<TEntity> returned by 
            // the DbSet.Local property to get the BindingList<T> 
            // in order to facilitate two-way binding in WinForms. 
            this.подразделенияBindingSource.DataSource =
               _context.Подразделения.Local.ToBindingList();
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

        private void подразделенияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Save();
            подразделенияDataGridView.Refresh();
        }

        private void ПодразделениеФорма_Load(object sender, EventArgs e)
        {

        }

        private void подразделенияDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
