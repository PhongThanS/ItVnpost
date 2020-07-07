using ItVnpost.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Data.Configurations
{
    public class CulturePictureConfiguration : IEntityTypeConfiguration<CulturePicture>
    {
        public void Configure(EntityTypeBuilder<CulturePicture> builder)
        {
            builder.ToTable("CulturePicture");
            //builder.Property(cp => cp.Content).IsRequired(true);
            builder.Property(cp => cp.Thumbnail).IsRequired(true);
            //builder.Property(cp => cp.Description).HasMaxLength(1500).IsRequired(false);
            //builder.Property(cp => cp.OrderPosition).IsRequired(true);
            //builder.Property(cp => cp.IsDisplay).IsRequired(true);
            builder.Property(c => c.DateCreated).HasDefaultValueSql("getdate()").ValueGeneratedOnAdd().IsRequired(true);
            //builder.Property(c => c.DateModified).HasDefaultValueSql("getdate()").ValueGeneratedOnUpdate().IsRequired(false);
            //builder.HasOne(cp => cp.CulturePost).WithOne(cp => cp.CulturePicture).HasForeignKey<CulturePicture>(cp => cp.CulturePostId).IsRequired(true).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(cp => cp.AppUser).WithMany(au => au.CulturePictures).HasForeignKey(cp => cp.UserIdCreated).IsRequired(false);
            builder.HasOne(cp => cp.CultureSection).WithMany(au => au.CulturePicturess).HasForeignKey(cp => cp.CultureSectionId);
            builder.HasOne(cp => cp.CulturePost).WithMany(au => au.CulturePictures).HasForeignKey(cp => cp.CulturePostId);
            builder.HasOne(cp => cp.CultureAlbum).WithMany(au => au.CulturePictures).HasForeignKey(cp => cp.CultureAlbumId);
            //builder.HasOne(cp => cp.AppUser).WithMany(au => au.CulturePictures).HasForeignKey(cp => cp.UserIdModified).IsRequired(false).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
