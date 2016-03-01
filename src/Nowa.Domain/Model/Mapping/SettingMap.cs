﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFSDDD.Model.Model.Mapping
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
