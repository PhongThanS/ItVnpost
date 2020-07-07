using ItVnpost.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Data.Configurations
{
	public class RecruitmentBannerConfiguration : IEntityTypeConfiguration<RecruitmentBanner>
	{
		public void Configure(EntityTypeBuilder<RecruitmentBanner> builder)
		{
			builder.ToTable("RecruitmentBanner");
			builder.HasKey(vt => vt.Id);
			builder.Property(vt => vt.TitleBanner).HasMaxLength(255);
			builder.Property(vt => vt.ImageRecruitment).IsRequired(true);
			builder.Property(vt => vt.IsDisplay);
			builder.Property(c => c.DateCreate).HasDefaultValueSql("getdate()").ValueGeneratedOnAdd().IsRequired(true);
			builder.Property(c => c.DateModified).HasDefaultValueSql("getdate()").ValueGeneratedOnUpdate().IsRequired(true);

		}
	}
}
