using System.Data.Entity.ModelConfiguration;

namespace ExamPro.Domain.Models.Mapping
{
    public class PatientMap : EntityTypeConfiguration<Patient>
    {
        public PatientMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);
            this.Property(t => t.Name).HasMaxLength(100);
        }
    }
}
