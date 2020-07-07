using ItVnpost.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Data.Configurations
{
    public class PartnerTypeConfiguration : IEntityTypeConfiguration<PartnerType>
    {
        public void Configure(EntityTypeBuilder<PartnerType> builder)
        {
            builder.ToTable("PartnerType");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.MenuId).IsRequired(true);
            builder.Property(x => x.Name).HasMaxLength(255).IsRequired(true);
            //builder.Property(x => x.ColorName).HasMaxLength(7).IsRequired(true);
            //builder.Property(x => x.ColorSlider).HasMaxLength(7).IsRequired(true);
            builder.Property(c => c.DateCreated).HasDefaultValueSql("getdate()").ValueGeneratedOnAdd().IsRequired(true);
            builder.Property(c => c.DateModified).HasDefaultValueSql("getdate()").ValueGeneratedOnUpdate().IsRequired(false);
            builder.Property(x => x.IsHidden).IsRequired(true);


            builder.HasOne(c => c.AppUser).WithMany(au => au.PartnerTypes).HasForeignKey(c => c.UserIdCreated).IsRequired(false).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(c => c.AppUser).WithMany(au => au.PartnerTypes).HasForeignKey(c => c.UserIdModified).IsRequired(false).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
