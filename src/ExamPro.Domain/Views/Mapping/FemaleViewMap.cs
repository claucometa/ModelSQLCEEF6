using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace ExamPro.Domain.Views.Mapping
{
    public class FemaleViewMap : EntityTypeConfiguration<FemaleView>
    {
        public FemaleViewMap()
        {
            this.HasKey(t => t.Id);

            this.HasRequired(t => t.Laudo)
                .WithMany(t => t.Femaleviews)
                .HasForeignKey(t => t.LaudoId)
                .WillCascadeOnDelete(true);

            this.HasRequired(t => t.Patient)
                .WithMany(t => t.FemaleReport)
                .HasForeignKey(t => t.PatientId)
                .WillCascadeOnDelete(true);

            this.HasOptional(t => t.Female)
                .WithMany(t => t.Females)
                .HasForeignKey(t => t.FemaleId);
        }
    }
}
