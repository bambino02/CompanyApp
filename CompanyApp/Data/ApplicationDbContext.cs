using CompanyApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CompanyApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>()
                .HasMany(e => e.Modules)
                .WithMany(e => e.Users)
                .UsingEntity<ModuleUser>();
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<ModuleUser> ModuleUser { get; set; }
    }
}