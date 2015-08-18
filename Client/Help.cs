using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleNetScanner
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Help_Load(object sender, EventArgs e)
        {
            string s = "<HTML> <HEAD> <TITLE>Your Title Here</TITLE></HEAD> <BODY BGCOLOR=\"FFFFFF\"> <iframe style=\"width: 100%; height: 100%; border: 0;\" frameborder=\"0\" src=\"http://reformal.ru/widget/835748\"></iframe><P> Для отправки отзыва требуется доступ в интернет.</BODY></HTML>";
            webBrowser1.DocumentText = s;
            webBrowser1.Refresh();
        }
    }
}
