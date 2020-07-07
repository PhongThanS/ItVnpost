using ItVnpost.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Data.Configurations
{
    public class ProjectCategoryConfiguration : IEntityTypeConfiguration<ProjectCategory>
    {
        public void Configure(EntityTypeBuilder<ProjectCategory> builder)
        {
            builder.ToTable("ProjectCategory");
            builder.HasKey(x => x.Id);
            builder.HasOne(m => m.Menu).WithMany(pc => pc.ProjectCategories).HasForeignKey(x => x.MenuId);
            builder.Property(x => x.Name).HasMaxLength(500);
            builder.Property(x => x.Alias).HasMaxLength(500);
            builder.Property(c => c.DateCreated).HasDefaultValueSql("getdate()").ValueGeneratedOnAdd();
        }
    }
}
