using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using CFSDDD.Model.Model;
using CFSDDD.Model.Model.Mapping;

namespace CFSDDD.Dal
{
    public class CFSContext : DbContext
    {
        static CFSContext()
        {
            Database.SetInitializer<CFSContext>(new DbInitializer());
           // using (var db = new CFSDDDContext("Data Source=D:/Db.sdf"))
           //     db.Database.Initialize(false);
        }

        public CFSContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {         
        }

        public DbSet<Setting> Settings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Settings
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
            // modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Configurations.Add(new SettingMap());

            base.OnModelCreating(modelBuilder);
        }
    }

    class DbInitializer : CreateDatabaseIfNotExists<CFSContext>
    {
        protected override void Seed(CFSContext context)
        {
            base.Seed(context);
        }
    }
}
