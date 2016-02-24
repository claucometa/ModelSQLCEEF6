using ExamPro.Winform.Forms;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ExamPro.Winform
{
    static class Program
    {
        // https://drive.google.com/folderview?id=0B7l10Bj_LprhQnpSRkpGMGV2eE0&usp=sharing
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Cursor.Current = Cursors.WaitCursor;

            ////MessageBox.Show(CheckIfServiceIsRunning("MYSQL55").ToString());
            //ExecuteInstaller(@"'C:\Users\Claudio\Source\Workspaces\Claucometa\ExamPRO\src\ExamPRO.Winform\Resources\mysql-5.5.44-win32.msi' ");
            //ExecuteCommand(@"'C:\Program Files (x86)\MySQL\MySQL Server 5.5\bin\mysqlinstanceconfig.exe' -i -q ServiceName='MySQL55' RootPassword='t5u8y67' ServerType=SERVER DatabaseType=MYISAM Port=3306 RootCurrentPassword=mysql");
          
            if (Config.GrantAccess()) Application.Run(new Main());

            //if (Config.GrantAccess())
            //{
            //    try
            //    {
            //        MyContext.CreateIfNotExists();
            //        Application.Run(new ExamPROMain());
            //    }
            //    catch (Exception ex)
            //    {
            //        Utils.ErrorHandling.AddError(ex);
            //        Utils.ErrorHandling.ShowErrors();
            //    }
            //}
        }

        public static bool CheckIfServiceIsRunning(string serviceName)
        {
            System.ServiceProcess.ServiceController mySC = new System.ServiceProcess.ServiceController(serviceName);
            if (mySC.Status == System.ServiceProcess.ServiceControllerStatus.Running)
            {
                // Service already running
                return true;
            }
            else
            {
                return false;
            }
        }

        static void ExecuteCommand(string command)
        {
            int exitCode;
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            process = Process.Start(processInfo);
            process.WaitForExit();
            exitCode = process.ExitCode;
            process.Close();
        }

        static void ExecuteInstaller(string command)
        {
            Process msiProcess = new Process();
            msiProcess.StartInfo.FileName = "msiexec.exe";
            msiProcess.StartInfo.Arguments = string.Format("/i {0} /passive", command);
            msiProcess.Start();
            msiProcess.WaitForExit();
            msiProcess.Close();
        }
    }

}
