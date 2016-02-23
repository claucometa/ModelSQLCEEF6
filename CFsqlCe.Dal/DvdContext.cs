using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using CFSqlCe.Domain.Model.Mapping;
using CFSqlCe.Domain.Model;

namespace CFSqlCe.Dal
{
    public class DvdContext : DbContext
    {
        static DvdContext()
        {
            Database.SetInitializer<DvdContext>(new DbInitializer());

            using (DvdContext db = new DvdContext())
                db.Database.Initialize(true);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<ActorRole> Roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Settings
            // modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
            // modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Configurations.Add(new ActorMap());
            modelBuilder.Configurations.Add(new ActorRoleMap());

            base.OnModelCreating(modelBuilder);
        }
    }

    class DbInitializer : CreateDatabaseIfNotExists<DvdContext>
    {
        protected override void Seed(DvdContext context)
        {
            base.Seed(context);
        }
    }
}
