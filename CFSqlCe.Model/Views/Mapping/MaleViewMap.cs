using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace CFSqlCe.Domain.Views.Mapping
{
    public class MaleViewMap : EntityTypeConfiguration<MaleView>
    {
        public MaleViewMap()
        {
            this.HasKey(t => t.Id);

            this.HasRequired(t => t.Laudo)
                .WithMany(t => t.Maleviews)
                .HasForeignKey(t => t.LaudoId)
                .WillCascadeOnDelete(true);

            this.HasRequired(t => t.Patient)
                .WithMany(t => t.MaleReport)
                .HasForeignKey(t => t.PatientId)
                .WillCascadeOnDelete(true);

            this.HasOptional(t => t.Male)
                .WithMany(t => t.Males)
                .HasForeignKey(t => t.MaleId);                
        }
    }
}
