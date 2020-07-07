using ItVnpost.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Data.Configurations
{
	public class ProjectConfiguration : IEntityTypeConfiguration<Project>
	{
		public void Configure(EntityTypeBuilder<Project> builder)
		{
			builder.ToTable("Projects");
			builder.HasKey(p => p.Id);
			builder.HasOne(m => m.Menu).WithMany(n => n.Projects).HasForeignKey(n => n.MenuId).OnDelete(DeleteBehavior.Restrict);
			builder.HasOne(pc => pc.ProjectCategory).WithMany(p => p.Projects).HasForeignKey(p => p.CategoryId).OnDelete(DeleteBehavior.Restrict);
			builder.Property(p => p.Name);
			builder.Property(p => p.Description);
			builder.Property(p => p.Thumbnail).IsRequired(false);
			builder.Property(p => p.Content).IsRequired(false);
			builder.Property(p => p.Alias).IsRequired(false);
			builder.Property(c => c.DateCreated).HasDefaultValueSql("getdate()").ValueGeneratedOnAdd();
			builder.Property(c => c.DateModified).HasDefaultValueSql("getdate()").ValueGeneratedOnUpdate();
			builder.Property(c => c.ViewCount).HasDefaultValueSql("0").ValueGeneratedOnAdd();
		}
	}
}
