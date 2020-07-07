using ItVnpost.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Data.Configurations
{
    public class ColorPageConfiguration : IEntityTypeConfiguration<ColorPage>
    {
        public void Configure(EntityTypeBuilder<ColorPage> builder)
        {
            builder.ToTable("ColorPage");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Color).HasMaxLength(50);
            builder.Property(x => x.ColorHover).HasMaxLength(50);
            builder.HasOne(m => m.Menu).WithMany(cp => cp.ColorPages).HasForeignKey(cp => cp.MenuId);
        }
    }
}
