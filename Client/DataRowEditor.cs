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
    public partial class DataRowEditor : Form 
    {
        List<CellView> cells = new List<CellView>();
        DataSet DD;
        AdvDataGridView dg;
        int row = -1;
        public DataRowEditor(ref AdvDataGridView DG, int rownum,bool withoutserver = true )
        {
            InitializeComponent();
            int i=0;
            dg = DG;
            DD = DG.DBSet ;
            row = rownum;
            dg.workwithoutserver = withoutserver;
            foreach (DataColumn  item in DD.Tables[0].Columns )
            {
                if (rownum == DD.Tables[0].Rows.Count)
                {                    
                    DD.Tables[0].Rows.Add(DD.Tables[0].NewRow());
                    //rownum--;
                    //row--;
                }
                try 
	            {
                    CellView cl = new CellView(item.Caption, DD.Tables[0].Rows[row][i].ToString(), i);
                    cl.Height = 30;
                    cl.Enabled = !dg.Rows[row].Cells[i].ReadOnly;
                    cl.Width = flowLayoutPanel1.ClientRectangle.Width - 32;
                    flowLayoutPanel1.Controls.Add(cl);
                    cl.Visible = true;
                    cells.Add(cl);
	            }
	            catch (Exception)
	            {
                    throw;
	            }
                i++;

            }
            int h = i * 40;
            if (h < 150)
            {
                this.Height = 140;
            }
            else
            {
                this.Height = h;
            }


        }
        private void DataRowEditor_Resize(object sender, EventArgs e)
        {
            foreach (var item in cells )
            {
                item.Width = flowLayoutPanel1.ClientRectangle.Width-32;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int i = 0;
            int rown = -1;
            int j = 0;
            foreach (DataGridViewRow  item in dg.Rows)
            {
                if (item.Index == row )
                {
                    break;
                }
                j++;
            }
            rown = j;
            foreach (DataColumn item in DD.Tables[0].Columns)
            {
                try
                {
                    if (cells[i].changed )
                    {
                        dg.Rows[rown].Cells[i].Value = cells[i].GetTextValue();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                i++;
            }
            this.Close();
        }
    }
}
