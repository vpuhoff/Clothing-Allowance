using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Drawing;
using remoteclass;
using System.IO;
using SimpleNetScanner;
using System.Runtime.InteropServices;
using System.Threading;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Collect(); //очистка мусора, установка параметров минимального потребления памяти
            TicketServer(); // инициализация прослушивателя
            do
            {
                Thread.Sleep(100); // тут можно разместить автопроцедуры сервера, если потребуется
            } while (true);
        }

        [DllImport("kernel32.dll")]
        private static extern bool SetProcessWorkingSetSize(IntPtr handle, int minimumWorkingSetSize, int maximumWorkingSetSize);
        public static void Collect()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);
        }
        //
        static ConfigCollection cfg = new ConfigCollection();
        //static string sharedfolder = "";

        static void WriteToLog(string status)
        {
            File.AppendAllText("Server.log", DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString() + status + "\r\n");
        }
        static void TicketServer() //инициализация сервера и настроек
        {
            string portnumber = "";
            WriteToLog("Запуск..."); //пишем лог
            if (File.Exists("Config.xml"))
            {
                WriteToLog("Файл настроек найден.");
                cfg.Load(@"Config.xml"); //загрузка параметров из файла конфигурации (номер порта)
                foreach (Config item in cfg.Collection)
                {
                    //if (item.Name == "Server") { server = item.Value; } //серверу не важно какой у него IP, слушает все доступные
                    if (item.Name == "Port") { portnumber = item.Value; }
                }
            }
            else
            {
                WriteToLog("Настройки не найдены, создайте файл настройки в меню приложения клиента.");
                return;
            }
            int port = 0;
            if (int.TryParse(portnumber, out port)) //проверяем корректность номера порта (не буквы)
            {
                try
                {
                    
                    TcpChannel ch = new TcpChannel(port);
                    ChannelServices.RegisterChannel(ch, false);//инициализация прослушивателя порта
                    RemotingConfiguration.CustomErrorsMode = CustomErrorsModes.On;
                    RemotingConfiguration.RegisterWellKnownServiceType(typeof
                                   (remoteclass.XX), "rahul", WellKnownObjectMode.Singleton); //регистрация "сервиса" remoteclass.XX в режиме Singleton https://msdn.microsoft.com/en-us/library/system.runtime.remoting.wellknownobjectmode(v=vs.110).aspx

                    WriteToLog("Sever is  Ready........");
                    Console.Read();

                    System.Console.WriteLine("Press ENTER to quitnn"); 
                    System.Console.ReadLine();
                }
                catch (Exception eee)
                {
                    WriteToLog(eee.Message);
                    return;
                }
               
            }
            else
            {
                WriteToLog("Введенный порт не является корректным или не является числом." + "/r");
                return;
            }
        }
    }
  

       
}
