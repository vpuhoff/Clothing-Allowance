using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;
using SimpleNetScanner;
using Client;


namespace WindowsFormsApplication12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();//трогать не нужно, вызов стандартной функции
        }
        
        string server = "";
        string port = "";
        bool workwithoutserver = true;
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

        ConfigCollection cfg = new ConfigCollection();
        void LoadConfig()
        {//если файл конфигурации есть загружаем параметры, если нет открываем окно настроек Form2
            if (File.Exists("Config.xml"))
            {
                cfg.Load("Config.xml");
                foreach (Config item in cfg.Collection)
                {
                    if (item.Name == "Server") { server = item.Value; }
                    if (item.Name == "Port") { port = item.Value; }
                    advDataGridView1.server = server;
                    advDataGridView1.port = port;
                }
            }
            else
            {
                Form2 frm = new Form2();
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Application.Restart();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadConfig();//чтение параметров сервера к которому подключаться
        }



        bool CheckConnect() //пример обращения к серверу и вызова функции
        {
            bool s=false ;
            try
            {
                var srv = Server();
                s = srv.Hello();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message ,"Сервер недоступен");
            }
            return s;
        }


        void GetDataAsync() //пример обращения к серверу Асинхронно, не тормозя поток интерфейса
        {
            Thread t = new Thread(GetDataThreadProc);
            t.Start();
        }

        void GetDataThreadProc() //пример обращения к серверу Асинхронно, не тормозя поток интерфейса
        {
            GC.Collect();
            BeginInvoke(new MethodInvoker(delegate
            {
                toolStripStatusLabel1.Text = "Обращение к серверу...";
            }));

                    var srv = Server(); //подключение к серверу
                    var result = srv.Scan(); //получение нужных данных
                    MessageBox.Show(result );

            BeginInvoke(new MethodInvoker(delegate
            {
                toolStripStatusLabel1.Text = "Готово...";
            }));
        }

        void GetData() //пример обращения к серверу синхронно, интерфейс "подвисает" пока выполняется запрос
        {
            var srv = Server(); //подключение к серверу
            var result= srv.Scan(); //получение нужных данных
            
        }


        private void тестовыйЗапросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataAsync();
        }

        private void получитьДанныеИзБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            advDataGridView1.ShowTable("SELECT * FROM Сотрудники", "Сотрудники");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void отзывыИПредложенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimpleNetScanner.Help hlp = new SimpleNetScanner.Help();
            hlp.ShowDialog();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Application.Restart();
            }
        }

        private void сохранитьДанныеВБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            advDataGridView1.SaveChangesInTable();
        }

        bool needsave()
        {
            return advDataGridView1.needsave;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (needsave() )
            {
                DialogResult res = MessageBox.Show("Сохранить изменения?", "БД Школа", MessageBoxButtons.YesNoCancel,
                   MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (res == System.Windows.Forms.DialogResult.Yes)
                {
                    advDataGridView1.SaveChangesInTable(false);
                }
                if (res == System.Windows.Forms.DialogResult.Cancel)
                {
                    e.Cancel = true ;
                }
            }
            
        }

        private void примерФормыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.advDataGridView1.ShowTable("SELECT * FROM Должность", "Должность");
            frm.advDataGridView1.SetColumnsReadOnly(new byte[] { 0, 1 });
            frm.ShowDialog();
        }

        private void advDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void formToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ученикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            advDataGridView1.ShowTable("SELECT * FROM Ученики", "Ученики");
            advDataGridView1.SetColumnsReadOnly(new byte[] { 0, 1 });
        }

        int id;
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < advDataGridView1.Rows.Count ; i++)
            {
                string s = advDataGridView1.Rows[i].Cells[1].Value.ToString() ;
                if (s == "Директор")
                {
                    id = i;
                    textBox1.Text = s;

                }
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            advDataGridView1.Rows[id].Cells[1].Value = textBox1.Text;
        }

        private void advDataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void advDataGridView1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in advDataGridView1.SelectedRows)
            {
                textBox1.Text = item.Cells[1].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
