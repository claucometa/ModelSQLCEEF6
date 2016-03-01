using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using CFSqlCe.Domain.Model.Mapping;
using CFSqlCe.Domain.Model;

namespace CFSqlCe.Dal
{
    public class CFSContext : DbContext
    {
        static CFSContext()
        {
            Database.SetInitializer<CFSContext>(new DbInitializer());

            using (CFSContext db = new CFSContext())
                db.Database.Initialize(true);
        }

        public DbSet<Setting> Settings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Settings
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();

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
