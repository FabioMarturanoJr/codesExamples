using InMemoryCrud.Domain.Core.Model;
using Microsoft.EntityFrameworkCore;

namespace InMemoryCrud.Infrastructure.Context
{
    public class DataBaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "TesteDb");
        }

        public DbSet<ComputadoresDataModel> Computadores { get; set; }
    }
}
