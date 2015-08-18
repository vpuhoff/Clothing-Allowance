using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Client
{
    public partial class AdvDataGridView : DataGridView
    {
        public bool needsave = false;
        public bool dataflow = false;
        public DataSet DBSet;
        public string commandText_; 
        public string tablename_;
        public string server { get; set; }
        public string port { get; set; }
        public bool workwithoutserver { get; set; }
        public delegate void DataLoaded();

        //Событие OnCount c типом делегата MethodContainer.
        public event DataLoaded onDataLoaded;

        public void ShowTable(string commandText, string tablename)
        {
            if (needsave)
            {
                DialogResult res = MessageBox.Show("Сохранить изменения?", "БД Школа", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (res == System.Windows.Forms.DialogResult.Yes)
                {
                    SaveChangesInTable(false);
                    if (dataflow == false)
                    {
                        dataflow = true;
                        commandText_ = commandText;
                        tablename_ = tablename;
                        Thread t = new Thread(ShowTableAsync);
                        t.Start();
                    }
                }
                if (res == System.Windows.Forms.DialogResult.Cancel)
                {
                    return;
                }
                if (res == System.Windows.Forms.DialogResult.No)
                {
                    needsave = false;
                    if (dataflow == false)
                    {
                        dataflow = true;
                        commandText_ = commandText;
                        tablename_ = tablename;
                        Thread t = new Thread(ShowTableAsync);
                        t.Start();
                    }
                }
            }
            else
            {
                if (dataflow == false)
                {
                    dataflow = true;
                    commandText_ = commandText;
                    tablename_ = tablename;
                    Thread t = new Thread(ShowTableAsync);
                    t.Start();
                }
            }
        }

        public string status = "";
        public bool loadready = false;
        byte[] columnsnum = new byte[0];

        void SetColumnReadOnly(byte columnnum, bool IsReadOnly)
        {
            this.Columns[columnnum].ReadOnly = IsReadOnly;
            DBSet.Tables[0].Columns[columnnum].ReadOnly = IsReadOnly;
        }

        void SetColumnsReadOnly()
        {
            foreach (DataGridViewColumn item in this.Columns)
            {
                item.ReadOnly = false;
            }
            foreach (DataColumn item in DBSet.Tables[0].Columns)
            {
                item.ReadOnly = false;
            }
            try
            {
                foreach (var item in columnsnum)
                {
                    SetColumnReadOnly(item, true );
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void SetColumnsReadOnly(byte[] columnsnum_)
        {
            columnsnum = columnsnum_;
        }

        void ShowTableAsync( )
        {
            try
            {
                BeginInvoke(new MethodInvoker(delegate
                {
                    status  = "Обращение к серверу...";
                    loadready = false;
                }));
                var srv = Server();
                DBSet = srv.GetItemsFromDB(commandText_, tablename_);
                //... инициализация dataGridView1 
                BeginInvoke(new MethodInvoker(delegate
                {
                    this.DataSource = DBSet.Tables[tablename_];
                    foreach (DataGridViewColumn column in this.Columns) column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    status  = "Данные получены.";
                    SetColumnsReadOnly();
                    dataflow = false;
                    loadready = true;
                    if (onDataLoaded!=null )
                    {
                        onDataLoaded();
                    }
                }));
            }
            catch (Exception)
            {
                dataflow = false;
                throw;
            }
        }

       public  void SaveChangesInTable(bool async = true)
        {
            if (async)
            {
                if (dataflow == false)
                {
                    dataflow = true;
                    Thread t = new Thread(SaveChangesInTableAsync);
                    t.Start();
                }
            }
            else
            {
                SaveChangesInTableAsync();
            }
            needsave = false;
        }

        void SaveChangesInTableAsync()
        {
            try
            {
                BeginInvoke(new MethodInvoker(delegate
                {
                    status  = "Обращение к серверу...";
                }));
                var srv = Server();
                srv.WriteDataToDB(DBSet, commandText_, tablename_);
                BeginInvoke(new MethodInvoker(delegate
                {
                    status  = "Изменения сохранены.";
                }));
                dataflow = false;
            }
            catch (Exception)
            {
                dataflow = false;
                throw;
            }
        }

        string GetUrl()//класс формирует URI сервера, менять не нужно
        {
            return "tcp://%server:%port/rahul".Replace("%server", server).Replace("%port", port);
        }

        remoteclass.XX Server()//инициализация классов для подключения к серверу и возвращение объекта подключенного к серверу и готового к взаимодействию.
        {
            remoteclass.XX obj = new remoteclass.XX();
            if (workwithoutserver)
            {
                return obj;
            }
            else
            {
                obj = (remoteclass.XX)Activator.GetObject(typeof(remoteclass.XX), GetUrl());
                return obj;
            }
        }
        public AdvDataGridView()
        {
            InitializeComponent();
            this.CellValueChanged += new DataGridViewCellEventHandler(AdvDataGridView_CellValueChanged);
        }

        void AdvDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            needsave = true;
        }

        private void AdvDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            
            
        }

        private void AdvDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите удалить строку?", "Удаление", MessageBoxButtons.YesNo , MessageBoxIcon.Exclamation) == DialogResult.Yes )
            {
                
            }
            else
            {
                e.Cancel = true;
            }
        }

       
    }
}
