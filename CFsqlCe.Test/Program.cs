using CFSqlCe.Dal;
using CFSqlCe.Domain.Model;
using System;
using System.Linq;

namespace CFSqlCe.Test
{
    // Nuget
    // Install-Package EntityFramework.SqlServerCompact

    class Program
    {
        static void Main(string[] args)
        {
            // Define the parameters of your database
            CFSContext.SetDataBaseOptions("D:/dbSuperTest.mdf");

            // Run this test to see if it works! 
            var x = MyContext.db.Settings.ToList();

            // You can create a service by simply using crud
            var repo = new CrudRepo<Setting>();
            x = repo.GetAll().ToList();

            Console.WriteLine(x.Count);
            Console.ReadKey();
            
        }
    }
}
