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
            Console.Write("Registros: ");
            Console.WriteLine(service.GetAll().Count());
            for (int i = 0; i < 10; i++) service.Add_AngelinaJolie();    
            service.Save();
            Console.Write("Novos Registros: ");
            Console.WriteLine(service.GetAll().Count());
            Console.Write("...");
            Console.ReadKey();            
        }
    }
}
