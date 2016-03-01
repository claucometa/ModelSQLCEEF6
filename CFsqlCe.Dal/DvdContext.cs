using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using CFSqlCe.Domain.Model.Mapping;
using CFSqlCe.Domain.Model;
using CFSqlCe.Domain.Views.Mapping;
using CFSqlCe.Domain.Views;

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

        public DbSet<Exam> Exams { get; set; }
        public DbSet<Sinonimo> Sinonimos { get; set; }
        public DbSet<Laudo> Reports { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<MaleView> MaleView { get; set; }
        public DbSet<FemaleView> FemaleView { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Settings
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
            // modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Configurations.Add(new ExamMap());
            modelBuilder.Configurations.Add(new SinonimoMap());
            modelBuilder.Configurations.Add(new LaudoMap());
            modelBuilder.Configurations.Add(new PatientMap());

            // Views
            modelBuilder.Configurations.Add(new MaleViewMap());
            modelBuilder.Configurations.Add(new FemaleViewMap());

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
