using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace CFSqlCe.Dal.Utils
{
    public static class ErrorHandling
    {
        public static event EventHandler Error;
        public static int ErrorsCount;
        const string logFile = @"C:\Windows\Temp\ExamProErrorLog.txt";
        public static void ShowErrors()
        {
            if (File.Exists(logFile))
                Process.Start(logFile);
            else
                MessageBox.Show("Nenhum erro encontrado!");
        }

        public static void AddError(Exception ex)
        {
            MessageBox.Show(ex.Message);
            ErrorsCount++;
            var msg = GetErrors(ex);
            var writetext = new StreamWriter(logFile);
            writetext.Write(msg);
            writetext.Close();
            if (Error != null) Error(null, null);
        }

        static string GetErrors(Exception ex)
        {
            string msg = DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString() + ". " + ex.ToString();
            while (ex.InnerException != null)
            {
                msg += msg + "---------------------";
                msg += ex.InnerException.ToString();
                ex = ex.InnerException;
            }
            return msg + "\r\n\r\n";
        }
    }
}
