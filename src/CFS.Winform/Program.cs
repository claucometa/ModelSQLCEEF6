using CFSDDD.Dal;
using System;
using System.Linq;
using System.Diagnostics;
using System.Windows.Forms;

namespace CFSDDD.Winform
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
            var z = MyContext.db.Settings.ToList();

            MessageBox.Show("Deu certo!\r\n\r\n" + MyContext.db.Database.Connection.ConnectionString);
        }
    }

}
