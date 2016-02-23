using CFSqlCe.Dal.Services;
using System;
using System.Linq;

namespace CFSqlCe.Test
{
    //Install-Package EntityFramework.SqlServerCompact

    class Program
    {
        static void Main(string[] args)
        {
            var service = new ServiceActor();
            for (int i = 0; i < 10; i++) service.Add_AngelinaJolie();    
            service.Save();
            Console.Write(service.GetAll().Count());
            Console.ReadKey();            
        }
    }
}
