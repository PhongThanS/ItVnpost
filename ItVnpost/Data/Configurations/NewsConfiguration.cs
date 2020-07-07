using ItVnpost.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Data.Configurations
{
    public class NewsConfiguration : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder.ToTable("News");
            builder.HasKey(n => n.Id);
            builder.HasOne(m => m.Menu).WithMany(n => n.News).HasForeignKey(n => n.MenuId);
            builder.HasOne(nc => nc.NewsCategory).WithMany(n => n.News).HasForeignKey(n => n.CategoryId);
            builder.Property(n => n.Name).IsRequired(true);
            builder.Property(n => n.Title);
            builder.Property(n => n.Alias).IsRequired(true);
            builder.Property(c => c.DateCreated).HasDefaultValueSql("getdate()").ValueGeneratedOnAdd();
            builder.Property(c => c.DateModified).HasDefaultValueSql("getdate()").ValueGeneratedOnUpdate();
            builder.Property(c => c.ViewCount).HasDefaultValueSql("0").ValueGeneratedOnAdd();
        }
    }
}
