using CFSDDD.Dal;
using System;
using System.Linq;
using System.Diagnostics;
using System.Windows.Forms;
using CFSDDD.Model.Model;

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
            
            // Accessing table "directly"
            var z = MyContext.db.Settings.ToList();

            // Using a CRUD example
            var repo = new CrudRepo<Setting>();
            z = repo.GetAll().ToList();


            MessageBox.Show("Deu certo!\r\n\r\nTabela criada em:\r\n\r\n" + MyContext.db.Database.Connection.ConnectionString);
        }
    }

}
