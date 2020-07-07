using ItVnpost.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Data.Configurations
{
    public class HomePageConfiguration : IEntityTypeConfiguration<HomePage>
    {
        public void Configure(EntityTypeBuilder<HomePage> builder)
        {
            builder.ToTable("HomePage");
            builder.HasKey(hp => hp.Id);
            builder.Property(hp => hp.SectionName).HasMaxLength(250).IsRequired(true);


            builder.HasOne(hp => hp.Menu).WithOne(m => m.HomePage).HasForeignKey<HomePage>(hp => hp.MenuId).IsRequired(true).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
