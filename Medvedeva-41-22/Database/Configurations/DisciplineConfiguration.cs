﻿
using Medvedeva_41_22.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Medvedeva_41_22.Database.Configurations
{
    public class DisciplineConfiguration : IEntityTypeConfiguration<Discipline>
    {
        public void Configure(EntityTypeBuilder<Discipline> builder)
        {
            builder.ToTable("Disciplines");
            builder.HasKey(d => d.Id);

            builder.Property(d => d.Name).IsRequired().HasMaxLength(100);

            // Связь "один-ко-многим" с нагрузкой
            builder.HasMany(d => d.Workloads)
                   .WithOne(w => w.Discipline)
                   .HasForeignKey(w => w.DisciplineId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}