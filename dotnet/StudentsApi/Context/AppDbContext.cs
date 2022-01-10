using Microsoft.EntityFrameworkCore;
using StudentsApi.Models;

namespace StudentsApi.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Student>? Students {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student {
                    Id = 1,
                    Name = "Fabio Marturano",
                    Email = "fabio.marturano@email.com",
                    Age = 27
                },
                new Student {
                    Id = 2,
                    Name = "Bruna Marturano",
                    Email = "bruna.marturano@email.com",
                    Age = 29
                }
            );
        }
    }
}