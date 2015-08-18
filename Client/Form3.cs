using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Client
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void сохранитьИзмененияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            advDataGridView1.SaveChangesInTable();
        }

        private void толькоДляЧтенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void advDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
