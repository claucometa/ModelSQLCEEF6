using CFSDDD.Core.Domain;
using CFSDDD.Dal.Mapping;
using System.Data.Entity;

namespace CFSDDD.Dal
{
    public class CFSContext : DbContext
    {
        static CFSContext()
        {
            Database.SetInitializer<CFSContext>(new DbInitializer());
        }

        public CFSContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {         

        }

        // Tables
        public DbSet<Setting> Settings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Settings
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();

            // Mapping
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
