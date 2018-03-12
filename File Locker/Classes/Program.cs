using System;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace File_Locker
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!Directory.Exists("Data")) { Directory.CreateDirectory("Data");
            }
            if (!File.Exists("Data/FileLocker.db"))
            {
                MessageBox.Show("No database found!", "Not Found");
                Application.Run(new NewPassword());
            }
            Application.Run(new EnterPassword());
            Thread.Sleep(500);
            Application.Run(new FileLocker());
        }
    }

    public static class Global
    {
        public const bool IS_DEBUGGING = true;
        public const bool IS_LOGGING = true;
        public const string FILE_LOCK_PASS = "45450A5558";
    }

    static class Logging
    {
        public static void WriteLog(string entry, string logType)
        {
            if (!Directory.Exists("Data/Logs")) { Directory.CreateDirectory("Data/Logs"); }

            string dir = "Data/Logs/" + logType + " " + DateTime.Now.ToString("yyyyMMdd") + ".txt";
            StreamWriter logFile = File.AppendText(dir);
            logFile.WriteLine(entry);
            logFile.Flush();
            logFile.Close();
        }
    }
}
