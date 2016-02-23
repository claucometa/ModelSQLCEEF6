using CFSqlCe.Dal;
using CFSqlCe.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CFSqlCe.Test
{
    //Install-Package EntityFramework.SqlServerCompact

    class Program
    {
        static void Main(string[] args)
        {
            var db = MyContext.db;
            var service = new ServiceActor();
            for (int i = 0; i < 3; i++) service.Add();    
            service.Save();
            Console.Write(db.Actors.Count());
            Console.ReadKey();            
        }
    }
}
