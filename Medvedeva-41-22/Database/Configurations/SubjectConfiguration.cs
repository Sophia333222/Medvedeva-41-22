using Medvedeva_41_22.Helpers;
using Medvedeva_41_22.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Medvedeva_41_22.Database.Configurations
{
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        private const string TableName = "Subject";
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.HasKey(p => p.SubjectId).HasName($"pk_{TableName}_subject_id");
            builder.Property(p => p.SubjectId).ValueGeneratedOnAdd().HasColumnName("Subject_ID");

            builder.Property(p => p.SubjectName)
                .IsRequired()
                .HasColumnName("Subject_Name")
                .HasColumnType(ColumnType.String)
                .HasMaxLength(100);

        }
    }
}