using ItVnpost.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Data.Configurations
{
    public class CulturePostConfiguration : IEntityTypeConfiguration<CulturePost>
    {
        public void Configure(EntityTypeBuilder<CulturePost> builder)
        {
            builder.ToTable("CulturePost");

            builder.HasKey(x => x.Id);
            builder.Property(cp => cp.Name).HasMaxLength(250).IsRequired(true);
            builder.Property(c => c.DateCreated).HasDefaultValueSql("getdate()").ValueGeneratedOnAdd().IsRequired(true);

            builder.HasOne(cp => cp.AppUser).WithMany(au => au.CulturePosts).HasForeignKey(cp => cp.UserIdCreated).IsRequired(false).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(cp => cp.AppUser).WithMany(au => au.CulturePosts).HasForeignKey(cp => cp.UserIdModified).IsRequired(false).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
