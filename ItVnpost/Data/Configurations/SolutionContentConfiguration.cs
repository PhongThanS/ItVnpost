using ItVnpost.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Data.Configurations
{
    public class SolutionContentConfiguration : IEntityTypeConfiguration<SolutionContent>
    {
        public void Configure(EntityTypeBuilder<SolutionContent> builder)
        {
            builder.ToTable("SolutionContent");
            builder.HasKey(sc => sc.Id);
            builder.HasOne(sc => sc.SolutionCategory).WithMany(sc => sc.SolutionContents).HasForeignKey(sc => sc.CategoryId);
            builder.Property(sc => sc.Name).HasMaxLength(255);
            builder.Property(sc => sc.Title).HasMaxLength(255);
            builder.Property(sc => sc.PathFile).HasMaxLength(255);
            builder.Property(sc => sc.Alias).HasMaxLength(255);
            builder.Property(c => c.DateCreated).HasDefaultValueSql("getdate()").ValueGeneratedOnAdd();
            builder.Property(c => c.DateModified).HasDefaultValueSql("getdate()").ValueGeneratedOnUpdate();
        }
    }
}
