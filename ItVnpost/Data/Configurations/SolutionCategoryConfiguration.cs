using ItVnpost.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Data.Configurations
{
    public class SolutionCategoryConfiguration : IEntityTypeConfiguration<SolutionCategory>
    {
        public void Configure(EntityTypeBuilder<SolutionCategory> builder)
        {
            builder.ToTable("SolutionCategory");
            builder.HasKey(sc => sc.Id);
            builder.HasOne(m => m.Menu).WithMany(sc => sc.SolutionCategories).HasForeignKey(sc => sc.MenuId);
            builder.Property(c => c.DateCreated).HasDefaultValueSql("getdate()").ValueGeneratedOnAdd();
            builder.Property(c => c.DateModified).HasDefaultValueSql("getdate()").ValueGeneratedOnUpdate();
        }
    }
}
