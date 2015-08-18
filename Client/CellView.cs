using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class CellView : UserControl
    {
        public CellView()
        {
            InitializeComponent();
        }

        TextBox valuetb = new TextBox();
        CheckBox  valuecb = new CheckBox();
        public int RowNum=-1;

        public enum CellType
        {
            none,
            text,
            check
        }

       public CellType mytype = CellType.none;
       public bool changed=false;

        public CellView(string label,string text,int cellnum)
        {
            InitializeComponent();
            RowNum = cellnum;
            label1.Text = label;
            splitContainer1.Panel2.Controls.Add(valuetb);
            valuetb.Visible = true;
            valuetb.Text = text;
            valuetb.Dock = DockStyle.Fill;
            valuetb.TextChanged += new EventHandler(valuetb_TextChanged);
            mytype = CellType.text;
        }

        void valuetb_TextChanged(object sender, EventArgs e)
        {
            changed = true;
        }

        public CellView(string label, bool value, int cellnum)
        {
            InitializeComponent();
            RowNum = cellnum;
            label1.Text = label;
            splitContainer1.Panel2.Controls.Add(valuecb);
            valuecb.Visible = true;
            valuecb.Checked = value;
            valuecb.Dock = DockStyle.Left ;
            mytype = CellType.check ;
        }

        public string GetTextValue()
        {
            return valuetb.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
