using ItVnpost.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Data.Configurations
{
    public class CultureSectionConfiguration : IEntityTypeConfiguration<CultureSection>
    {
        public void Configure(EntityTypeBuilder<CultureSection> builder)
        {
            builder.ToTable("CultureSection");
            builder.HasKey(cs => cs.Id);
            builder.Property(cs => cs.Name).HasMaxLength(250).IsRequired(true);
            builder.Property(c => c.DateCreated).HasDefaultValueSql("getdate()").ValueGeneratedOnAdd().IsRequired(true);
            builder.Property(c => c.DateModified).HasDefaultValueSql("getdate()").ValueGeneratedOnUpdate().IsRequired(false);

            builder.HasOne(cs => cs.CultureLayout).WithMany(c => c.CultureSections).HasForeignKey(cs => cs.CultureLayoutId).IsRequired(true).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(cs => cs.Menu).WithMany(c => c.CultureSections).HasForeignKey(cs => cs.MenuId).IsRequired(true).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(cs => cs.AppUser).WithMany(au => au.CultureSections).HasForeignKey(cp => cp.UserIdCreated).IsRequired(false).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(cs => cs.AppUser).WithMany(au => au.CultureSections).HasForeignKey(cp => cp.UserIdModified).IsRequired(false).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
