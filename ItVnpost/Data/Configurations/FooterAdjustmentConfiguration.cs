using ItVnpost.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Data.Configurations
{
    public class FooterAdjustmentConfiguration : IEntityTypeConfiguration<FooterAdjustment>
    {
        public void Configure(EntityTypeBuilder<FooterAdjustment> builder)
        {
            builder.ToTable("FooterAdjustment");
            builder.HasKey(ma => ma.Id);
            builder.Property(ma => ma.Property).HasMaxLength(250).IsRequired(true);
            builder.Property(ma => ma.Value).HasMaxLength(500).IsRequired(true);
        }
    }
}
