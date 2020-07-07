using ItVnpost.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Data.Configurations
{
    public class PartnerConfiguration : IEntityTypeConfiguration<Partner>
    {
        public void Configure(EntityTypeBuilder<Partner> builder)
        {
            builder.ToTable("Partner");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(255).IsRequired(true);
            builder.Property(x => x.Image).IsRequired(true);
            builder.Property(c => c.DateCreated).HasDefaultValueSql("getdate()").ValueGeneratedOnAdd().IsRequired(true);
            builder.Property(c => c.DateModified).HasDefaultValueSql("getdate()").ValueGeneratedOnUpdate().IsRequired(false);


            builder.HasOne<PartnerType>(x => x.PartnerType).WithMany(y => y.Partners).HasForeignKey(s => s.PartnerTypeId);

            builder.HasOne(c => c.AppUser).WithMany(au => au.Partners).HasForeignKey(c => c.UserIdCreated).IsRequired(false).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(c => c.AppUser).WithMany(au => au.Partners).HasForeignKey(c => c.UserIdModified).IsRequired(false).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
