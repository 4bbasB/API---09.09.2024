using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using API___09._09._2024.Entities;

namespace API___09._09._2024.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(x => x.Fullname).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Grade).IsRequired();
            builder.HasOne(x => x.Group).WithMany(x => x.Students).HasForeignKey(x => x.GroupId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
