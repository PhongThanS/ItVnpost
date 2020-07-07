using ItVnpost.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Data.Configurations
{
	public class RecruitmentCareersConfiguration : IEntityTypeConfiguration<RecruitmentCareers>
	{
		public void Configure(EntityTypeBuilder<RecruitmentCareers> builder)
		{
			builder.ToTable("RecruitmentCareers");
			builder.HasKey(vt => vt.Id);
			builder.Property(vt => vt.NameCareer).HasMaxLength(255);
			builder.Property(c => c.DateCreate).HasDefaultValueSql("getdate()").ValueGeneratedOnAdd().IsRequired(true);
			builder.Property(c => c.DateModified).HasDefaultValueSql("getdate()").ValueGeneratedOnUpdate().IsRequired(true);
		}
	}
}
