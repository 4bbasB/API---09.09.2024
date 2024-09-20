using API___09._09._2024.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API___09._09._2024.Configurations
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(30);
            builder.Property(x => x.GroupNo).IsRequired().HasMaxLength(5);
        }
    }
}
