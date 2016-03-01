using System.Data.Entity;
using ExamPro.Domain.Models.Mapping;
using ExamPro.Domain.Models;
using ExamPro.Domain.Views.Mapping;
using ExamPro.Domain.Views;
using System.Data.Entity.Migrations;
using ExamPro.DataAccess;

namespace ExamPro.DataAccess
{
    // [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public partial class ExamProContext : DbContext
    {
        static ExamProContext()
        {
            // DbConfiguration.SetConfiguration(new MySql.Data.Entity.MySqlEFConfiguration());
            Database.SetInitializer(new MySqlInitializer());
        }

        public ExamProContext()
            : base("Name=examproContext")
        {
            //    Database.Connection.ConnectionString = conn;
        }

        public DbSet<Exam> Exams { get; set; }
        public DbSet<Sinonimo> Sinonimos { get; set; }
        public DbSet<Laudo> Reports { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<MaleView> MaleView { get; set; }
        public DbSet<FemaleView> FemaleView { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new ExamMap());
            modelBuilder.Configurations.Add(new SinonimoMap());
            modelBuilder.Configurations.Add(new LaudoMap());
            modelBuilder.Configurations.Add(new PatientMap());

            // Views
            modelBuilder.Configurations.Add(new MaleViewMap());
            modelBuilder.Configurations.Add(new FemaleViewMap());

            // Settings
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            base.OnModelCreating(modelBuilder);
        }

        public static void InitSeed(ExamProContext context)
        {
            var exams = Seed.SeedExams(context);
            context.Exams.AddOrUpdate(exams);
            context.Sinonimos.AddOrUpdate(Seed.SeedSinonyms(exams, context));
            context.SaveChanges();
        }
    }
}
