using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SimpleNetScanner
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
       
        private void Form2_Load(object sender, EventArgs e)
        {
            if (File.Exists("Config.xml"))
            {
                cfg.Load("Config.xml");
                foreach (Config  item in cfg.Collection )
                {
                    if (item.Name == "Server"){server.Text = item.Value;}
                    if (item.Name == "Port") { port.Text = item.Value; }
                    if (item.Name == "Folder") { textBox1.Text = item.Value; }
                }
            }
            
        }

        ConfigCollection cfg = new ConfigCollection();

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Config srcf = new Config("Server", server.Text);
            Config portcf = new Config("Port", port.Text);
            Config fldcf = new Config("Folder", textBox1.Text);
            cfg.Collection.Clear();
            cfg.Collection.Add(srcf);
            cfg.Collection.Add(portcf);
            cfg.Collection.Add(fldcf);
            cfg.Save("Config.xml");
            this.DialogResult = System.Windows.Forms.DialogResult.OK ;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowNewFolderButton = true;
            folderBrowserDialog1.ShowDialog();
            textBox1.Text = folderBrowserDialog1.SelectedPath +"\\";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowNewFolderButton = true;
            folderBrowserDialog1.ShowDialog();
        }
    }
}
