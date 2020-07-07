using ItVnpost.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Data.Configurations
{
    public class HomePageBannerConfiguration : IEntityTypeConfiguration<HomePageBanner>
    {
        public void Configure(EntityTypeBuilder<HomePageBanner> builder)
        {
            builder.ToTable("HomePageBanner");

            builder.HasKey(hb => hb.Id);

            builder.Property(hb => hb.Content).IsRequired(true);
            builder.Property(hb => hb.Description).IsRequired(false);
        }
    }
}
