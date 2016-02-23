using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace CFSqlCe.Domain.Model.Mapping
{
    public class ActorRoleMap : EntityTypeConfiguration<ActorRole>
    {
        public ActorRoleMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);
            this.Property(t => t.Character).HasMaxLength(50);
            this.Property(t => t.Description).HasMaxLength(50);

            this.HasRequired(t => t.Actor)
                .WithMany(t => t.Roles)
                .HasForeignKey(t => t.ActorId);
        }
    }
}
