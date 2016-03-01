using System.Data.Entity.ModelConfiguration;

namespace ExamPro.Domain.Models.Mapping
{
    public class SinonimoMap : EntityTypeConfiguration<Sinonimo>
    {
        public SinonimoMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ExamId, t.Sym });

            // Properties
            this.Property(t => t.Sym).HasMaxLength(100);

            this.HasRequired(t => t.Exam)                
                .WithMany(t => t.Sinonimos)
                .HasForeignKey(t => t.ExamId)
                .WillCascadeOnDelete(true);
        }
    }
}
