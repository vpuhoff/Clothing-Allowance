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

namespace Client.СправочникиФормы
{
    public partial class НормативыФорма : Form
    {
        DatabaseSQLEntities _context;
        public НормативыФорма()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context = new DatabaseSQLEntities();

            _context.Нормативы.Load();
            _context.ФормыОбеспечения.Load();
            _context.Звания.Load();
            _context.Предметы.Load();

            this.нормативыBindingSource.DataSource =
                _context.Нормативы.Local.ToBindingList();

            this.формыОбеспеченияBindingSource.DataSource =
                 _context.ФормыОбеспечения.Local.ToBindingList();

            this.званияBindingSource.DataSource =
                 _context.Звания.Local.ToBindingList();

            this.предметыBindingSource.DataSource =
                 _context.Предметы.Local.ToBindingList();
            
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

        private void нормативыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Save();
            нормативыDataGridView.Refresh();
        }
    }
}
