using ItVnpost.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Data.Configurations
{
    public class MenuAdjustmentConfiguration : IEntityTypeConfiguration<MenuAdjustment>
    {
        public void Configure(EntityTypeBuilder<MenuAdjustment> builder)
        {
            builder.ToTable("MenuAdjustment");
            builder.HasKey(ma => ma.Id);
            builder.Property(ma => ma.Property).HasMaxLength(250).IsRequired(true);
        }
    }
}
