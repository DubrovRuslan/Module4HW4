﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW4.Entities;

namespace Module4HW4.EntityConfigurations
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Project").HasKey(p => p.Id);
            builder.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(p => p.Name).HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            builder.Property(p => p.Budget).HasColumnType("money").IsRequired();
            builder.Property(p => p.StartedDate).HasColumnType("datetime2").IsRequired().HasMaxLength(7);
            builder.HasOne(p => p.Client)
                .WithMany(c => c.Projects)
                .HasForeignKey(p => p.ClientId)
                .OnDelete(DeleteBehavior.Cascade);
            ////builder.HasData(new List<Project>()
            ////{
            ////    new Project() { Budget = 1000, Name = "Tesla", StartedDate = DateTime.UtcNow },
            ////    new Project() { Budget = 2000, Name = "Facebook", StartedDate = DateTime.UtcNow },
            ////    new Project() { Budget = 3000, Name = "Linux", StartedDate = DateTime.UtcNow },
            ////    new Project() { Budget = 4000, Name = "Windows XP", StartedDate = DateTime.UtcNow },
            ////    new Project() { Budget = 5000, Name = "Blue Origin", StartedDate = DateTime.UtcNow }
            ////});
        }
    }
}
