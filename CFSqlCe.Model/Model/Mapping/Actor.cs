using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace CFSqlCe.Domain.Model.Mapping
{
    public class ActorMap : EntityTypeConfiguration<Actor>
    {
        public ActorMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);
            this.Property(t => t.Name).HasMaxLength(50);
            this.Property(t => t.Surname).HasMaxLength(50);
            this.Property(t => t.Note).HasMaxLength(200);            
        }
    }
}
