using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using SimpleNetScanner;
using System.Runtime.InteropServices;
using System.Data.OleDb;
using System.Data;
using System.Threading;

namespace remoteclass
{
    public class XX : MarshalByRefObject
    {
       //в этом классе описываются все процедуры для взаимодействия с БД 
        string fileName = @"..\Database\Database21.mdb";
        string connectionStr = "Provider=Microsoft.Jet.OLEDB.4.0;"; 
        
        public bool Hello()//пример вызываемой функции
        {
            return true;
        }


        [DllImport("kernel32.dll")]
        private static extern bool SetProcessWorkingSetSize(IntPtr handle, int minimumWorkingSetSize, int maximumWorkingSetSize); //нужен для Collect
        public static void Collect() //процедура принудительной очистки мусора, нужен был после работы с Не.net библиотеками, которые за собой мусор убирать не умеют
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);
        }

        private  ConfigCollection cfg = new ConfigCollection(); //объект класса для работы с файлом конфигурации, если он будет нужен
        public string Scan(long quality=300) //пример вызываемой функции
        {
            //здесь может быть код обращения к БД и возвращения полученного значения, в данном случае строки
            System.Console.WriteLine("Scanning ....");
            Thread.Sleep(10000);
            return "50 человек";
        }

        public List<String> GetItems(string id) //пример вызываемой функции
        {
            //здесь может быть код обращения к БД и возвращения полученного значения, в данном случае списка строк
            System.Console.WriteLine("Scanning ....");
            List<String> list = new List<string>();
            list.Add("sdasdasdasd");
            return list;
        }

        public string[] GetItems2(string id) //пример вызываемой функции
        {
            //здесь может быть код обращения к БД и возвращения полученного значения, в данном случае массива строк
            System.Console.WriteLine("Scanning ....");
            var list = new string[2];
            list[0]="sdasdasdasd";
            return list;
        }


        public DataSet GetItemsFromDB(string commandText, string tablename) //пример вызываемой функции
        {
            //здесь может быть код обращения к БД и возвращения полученного значения, в данном случае массива строк
            OleDbConnection oleCon; 
            OleDbDataAdapter DBAdapter; 
            DataSet DBSet = new DataSet();
  
            //... инициализация БД 
            if (!connectionStr.Contains("mdb")){connectionStr += "Data Source=\"" + fileName + "\"";}
            
            oleCon = new OleDbConnection(connectionStr); 
            DBAdapter = new OleDbDataAdapter(commandText, oleCon);
            DBAdapter.Fill(DBSet, tablename);
            //DBSet.Tables[0].PrimaryKey = new DataColumn[] { DBSet.Tables["Ученики"].Columns["№ЛичногоДела"] };
            //DBSet.Tables[0].Columns["id"].Unique = true;
            //DBSet.Tables[0].Columns["id"].AutoIncrement = true;

            return DBSet;
            //... инициализация dataGridView1 
            //dataGridView1.DataSource = DBSet.Tables["Ученики"]; 
            //foreach (DataGridViewColumn column in dataGridView1.Columns) column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; 
  
            //... обработчик кнопки УДАЛИТЬ 
            // предположим, что в dataGridView1 была выбрана строка у которой ячейка "id"=78 
            //this.GetRowByID(DBSet.Tables["table1"], 78).Delete();  
            

        }

        public bool WriteDataToDB(DataSet DBSet, string commandText,string tablename)
        {//... обновление БД 
            OleDbConnection oleCon;
            OleDbDataAdapter DBAdapter;
            //... инициализация БД 
            if (!connectionStr.Contains("mdb")){ connectionStr += "Data Source=\"" + fileName + "\""; }
            oleCon = new OleDbConnection(connectionStr);
            DBAdapter = new OleDbDataAdapter(commandText, oleCon);
            OleDbCommandBuilder cmdBuild = new OleDbCommandBuilder(DBAdapter);
            DBAdapter.UpdateCommand = cmdBuild.GetUpdateCommand();
            DBAdapter.InsertCommand = cmdBuild.GetInsertCommand();
            DBAdapter.DeleteCommand = cmdBuild.GetDeleteCommand();
            DBAdapter.Update(DBSet.Tables[tablename]);
            return true;
        }
        public DataRow GetRowByID(DataTable table, int id)
        {
            return table.Rows.Find(id);
        } 


        public String ByteToString(byte[] byteArray)
        {
            return Convert.ToBase64String(byteArray);
        }

    }
}
