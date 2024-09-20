using API___09._09._2024.Configurations;
using API___09._09._2024.Entities;
using Microsoft.EntityFrameworkCore;

namespace API___09._09._2024.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GroupConfiguration).Assembly);
            base.OnModelCreating(modelBuilder);
        }

    }
}
