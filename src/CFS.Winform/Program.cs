﻿using CFSDDD.Dal;
using CFSDDD.Dal.Repo;
using System;
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

            using (var x = new UnitOfWork(MainContext.Production))
            {
                var k = x.Settings.GetAll();
            }

            MessageBox.Show("Ok");
        }
    }

}
