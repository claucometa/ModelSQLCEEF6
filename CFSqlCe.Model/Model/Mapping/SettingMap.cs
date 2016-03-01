using System.Data.Entity.ModelConfiguration;

namespace CFSqlCe.Domain.Model.Mapping
{
    public class SettingMap : EntityTypeConfiguration<Setting>
    {
        public SettingMap()
        {
            // Primary Key
            this.HasKey(t => t.Nome );

            // Properties
            this.Property(t => t.Nome).HasMaxLength(100);
            this.Property(t => t.Valor).HasMaxLength(300);
        }
    }
}
