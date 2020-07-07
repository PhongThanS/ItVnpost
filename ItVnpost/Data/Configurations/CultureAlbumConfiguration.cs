using ItVnpost.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Data.Configurations
{
    public class CultureAlbumConfiguration : IEntityTypeConfiguration<CultureAlbum>
    {
        public void Configure(EntityTypeBuilder<CultureAlbum> builder)
        {
            builder.ToTable("CultureAlbum");
            builder.HasKey(cap => cap.Id);
            builder.Property(cap => cap.Name).HasMaxLength(250).IsRequired(true);
            builder.Property(c => c.DateCreated).HasDefaultValueSql("getdate()").ValueGeneratedOnAdd();
            builder.Property(c => c.DateModified).HasDefaultValueSql("getdate()").ValueGeneratedOnUpdate();

            builder.HasOne(cs => cs.CultureSection).WithMany(cap => cap.CultureAlbums).HasForeignKey(cap => cap.SectionId).IsRequired(true).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(au => au.AppUser).WithMany(cap => cap.CultureAlbums).HasForeignKey(cap => cap.UserIdCreated).IsRequired(false).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(au => au.AppUser).WithMany(cap => cap.CultureAlbums).HasForeignKey(cap => cap.UserIdModified).IsRequired(false).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
