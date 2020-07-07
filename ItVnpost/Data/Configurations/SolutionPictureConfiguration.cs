using ItVnpost.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Data.Configurations
{
    public class SolutionPictureConfiguration : IEntityTypeConfiguration<SolutionPicture>
    {
        public void Configure(EntityTypeBuilder<SolutionPicture> builder)
        {
            builder.ToTable("SolutionPicture");
            builder.HasKey(sp => sp.Id);
            builder.HasOne(sc => sc.SolutionContent).WithMany(sp => sp.SolutionPictures).HasForeignKey(sp => sp.ContentId);
            builder.Property(c => c.DateCreated).HasDefaultValueSql("getdate()").ValueGeneratedOnAdd();
            builder.Property(c => c.DateModified).HasDefaultValueSql("getdate()").ValueGeneratedOnUpdate();
        }
    }
}
