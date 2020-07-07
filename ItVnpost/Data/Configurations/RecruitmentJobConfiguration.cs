using ItVnpost.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Data.Configurations
{
	public class RecruitmentJobConfiguration : IEntityTypeConfiguration<RecruitmentJob>
	{
		public void Configure(EntityTypeBuilder<RecruitmentJob> builder)
		{
			builder.ToTable("RecruitmentJob");
			builder.HasKey(x => x.Id);
			builder.HasOne(m => m.Menu).WithMany(x => x.RecruitmentJobs).HasForeignKey(x => x.MenuId);
			builder.HasOne(m => m.RecruitmentCareers).WithMany(x => x.RecruitmentJobs).HasForeignKey(x => x.CareerId);
			builder.Property(x => x.Title).HasMaxLength(255).IsRequired(true);
			builder.Property(x => x.ImageJob).IsRequired(false);
			builder.Property(x => x.UserContact).HasMaxLength(255);
			builder.Property(x => x.PhoneContact).HasMaxLength(11);
			builder.Property(x => x.EmailContact).HasMaxLength(30);
			builder.Property(c => c.DateCreate).HasDefaultValueSql("getdate()").ValueGeneratedOnAdd() ;
			builder.Property(c => c.DateModified).HasDefaultValueSql("getdate()").ValueGeneratedOnUpdate();

		}
	}
}
