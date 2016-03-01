using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using CFSDDD.Domain.Model.Mapping;
using CFSDDD.Domain.Model;

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

    class DbInitializer : CreateDatabaseIfNotExists<CFSContext>
    {
        protected override void Seed(CFSContext context)
        {
            var exams = CFSDDD.Dal.SeedData.SeedExams(context);
            context.Exams.AddRange(exams);
            var sins = CFSDDD.Dal.SeedData.SeedSinonyms(exams, context);
            context.Sinonimos.AddRange(sins);
            context.SaveChanges();
            //base.Seed(context);
        }
    }
}
