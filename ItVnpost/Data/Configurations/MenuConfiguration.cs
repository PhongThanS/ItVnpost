using ItVnpost.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Data.Configurations
{
    public class MenuConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.ToTable("Menu");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ParentId).IsRequired(true);
            builder.Property(x => x.Name).HasMaxLength(255).IsRequired(true);
            builder.Property(x => x.Href).HasMaxLength(500).IsRequired(false);
            builder.Property(x => x.OrderPosition).IsRequired(false);
            builder.Property(x => x.IsDisplayHome).IsRequired(true);
            builder.Property(x => x.LayoutId).IsRequired(true);
            builder.Property(x => x.MenuIcon).IsRequired(false);
            builder.Property(x => x.IsHidden).IsRequired(true);
            builder.Property(c => c.DateCreated).HasDefaultValueSql("getdate()").ValueGeneratedOnAdd().IsRequired(true);
            builder.Property(c => c.DateModified).HasDefaultValueSql("getdate()").ValueGeneratedOnUpdate().IsRequired(false);

            builder.HasOne(x => x.Layout).WithMany(l => l.Menus).HasForeignKey(m=>m.LayoutId);
            builder.HasOne(m => m.AppUser).WithMany(au => au.Menus).HasForeignKey(m => m.UserIdCreated).IsRequired(false).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(m => m.AppUser).WithMany(au => au.Menus).HasForeignKey(m => m.UserIdModified).IsRequired(false).OnDelete(DeleteBehavior.Restrict);
        }

    }
}
