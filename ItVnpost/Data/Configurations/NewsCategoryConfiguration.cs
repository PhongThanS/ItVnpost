using ItVnpost.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Data.Configurations
{
    public class NewsCategoryConfiguration : IEntityTypeConfiguration<NewsCategory>
    {
        public void Configure(EntityTypeBuilder<NewsCategory> builder)
        {
            builder.ToTable("NewsCategory");
            builder.HasKey(x => x.Id);
            builder.HasOne(m => m.Menu).WithMany(nc => nc.NewsCategories).HasForeignKey(n => n.MenuId);
            builder.Property(n => n.Name).HasMaxLength(500);
            builder.Property(n => n.Alias).HasMaxLength(500);
            builder.Property(c => c.DateCreated).HasDefaultValueSql("getdate()").ValueGeneratedOnAdd();
        }
    }
}
