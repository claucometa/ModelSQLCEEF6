using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using CFSqlCe.Domain.Model.Mapping;
using CFSqlCe.Domain.Model;

namespace CFSqlCe.Dal
{
    public class HollywoodContext : DbContext
    {
        static HollywoodContext()
        {
            Database.SetInitializer<HollywoodContext>(new DbInitializer());
            using (HollywoodContext db = new HollywoodContext())
                db.Database.Initialize(false);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<ActorRole> Roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Settings
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Configurations.Add(new ActorMap());
            modelBuilder.Configurations.Add(new ActorRoleMap());
            
            base.OnModelCreating(modelBuilder);
        }
    }

    

    class DbInitializer : DropCreateDatabaseAlways<HollywoodContext>
    {
        protected override void Seed(HollywoodContext context)
        {
            // some roles
            context.Roles.Add(new ActorRole()
            {
                 Description = "Lead"
            });
            context.Roles.Add(new ActorRole()
            {
                Description = "Supporting"
            });
            context.Roles.Add(new ActorRole()
            {
                Description = "Background"
            });

            // some actors
            context.Actors.Add(new Actor()
            {
                Name = "Chris",
                Surname = "Pine",
                Note = "Born in Los Angeles, California"
            });
            context.Actors.Add(new Actor()
            {
                Name = "Zachary",
                Surname = "Quinto",
                Note = "Zachary Quinto graduated from Central Catholic High School in Pittsburgh"
            });
            context.Actors.Add(new Actor()
            {
                Name = "Tom",
                Surname = "Cruise"
            });

            // insert some file generes
            base.Seed(context);
        }
    }
}
