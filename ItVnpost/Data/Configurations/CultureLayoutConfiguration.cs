using ItVnpost.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Data.Configurations
{
    public class CultureLayoutConfiguration : IEntityTypeConfiguration<CultureLayout>
    {
        public void Configure(EntityTypeBuilder<CultureLayout> builder)
        {
            builder.ToTable("CultureLayout");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(250).IsRequired(true);
            builder.Property(c => c.DateCreated).HasDefaultValueSql("getdate()").ValueGeneratedOnAdd().IsRequired(true);
            builder.Property(c => c.DateModified).HasDefaultValueSql("getdate()").ValueGeneratedOnUpdate().IsRequired(false);

            builder.HasOne(c => c.AppUser).WithMany(au => au.Cultures).HasForeignKey(c => c.UserIdCreated).IsRequired(false).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(c => c.AppUser).WithMany(au => au.Cultures).HasForeignKey(c => c.UserIdModified).IsRequired(false).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
