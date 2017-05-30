using CFSDDD.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace CFSDDD.Dal.Mapping
{
    public class SettingMap : EntityTypeConfiguration<Setting>
    {
        public SettingMap()
        {
            // Primary Key
            this.HasKey(t => t.Nome);
            this.Property(t => t.Valor).HasMaxLength(100);
            this.Property(t => t.Nome).HasMaxLength(500);
        }
    }
}
