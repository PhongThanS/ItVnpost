using ItVnpost.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItVnpost.Data.Configurations
{
    public class VisionMissionConfiguration : IEntityTypeConfiguration<VisionMission>
    {
        public void Configure(EntityTypeBuilder<VisionMission> builder)
        {
            builder.ToTable("VisionMission");
            builder.HasKey(x => x.Id);
            builder.Property(vm => vm.Name).HasMaxLength(250).IsRequired(true);
            builder.Property(vm => vm.Title).HasMaxLength(255);
            builder.Property(c => c.DateCreated).HasDefaultValueSql("getdate()").ValueGeneratedOnAdd();
            builder.Property(c => c.DateModified).HasDefaultValueSql("getdate()").ValueGeneratedOnUpdate();

            builder.HasOne(vm => vm.Menu).WithMany(m => m.VisionMissions).HasForeignKey(vm => vm.MenuId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
