using System.Data.Entity.ModelConfiguration;

namespace CFSqlCe.Domain.Model.Mapping
{
    public class LaudoMap : EntityTypeConfiguration<Laudo>
    {
        public LaudoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);
            this.Property(t => t.Description).HasMaxLength(50);
            this.Property(t => t.Lab).HasMaxLength(50);
            this.Property(t => t.FilePath).HasMaxLength(257);

            this.HasRequired(t => t.Patient)
                .WithMany(t => t.Laudos)
                .HasForeignKey(t => t.PatientId)
                .WillCascadeOnDelete(true);
        }
    }
}
