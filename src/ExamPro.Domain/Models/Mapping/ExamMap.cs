using System.Data.Entity.ModelConfiguration;

namespace ExamPro.Domain.Models.Mapping
{
    public class ExamMap : EntityTypeConfiguration<Exam>
    {
        public ExamMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Nome)
                .HasMaxLength(100);

            this.Property(t => t.Unidade)
                .HasMaxLength(10);
        }
    }
}
