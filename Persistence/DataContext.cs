using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Value>(builder =>
            {
                builder.HasData(
                    new Value { Id = 1, Name = "value 101" },
                    new Value { Id = 2, Name = "value 102" },
                    new Value { Id = 3, Name = "value 103" }
                );
            });
        }
        public DbSet<Value> Values { get; set; }
    }
}
