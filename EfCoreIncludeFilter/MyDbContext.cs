using EfCoreIncludeFilter.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace EfCoreIncludeFilter
{
    public class MyDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Record> Records { get; set; }

        public MyDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1 }, new Category { Id = 2 }, new Category { Id = 3 }
            );

            modelBuilder.Entity<Record>().HasData(
                new Record { Id = 1, CategoryId = 1, LastUpdate = new DateTime(2021, 10, 10) },
                new Record { Id = 2, CategoryId = 2, LastUpdate = new DateTime(2021, 10, 11) },
                new Record { Id = 3, CategoryId = 3, LastUpdate = new DateTime(2021, 10, 12) },
                new Record { Id = 4, CategoryId = 3, LastUpdate = new DateTime(2021, 10, 13) },
                new Record { Id = 5, CategoryId = 1, LastUpdate = new DateTime(2021, 10, 14) },
                new Record { Id = 6, CategoryId = 1, LastUpdate = new DateTime(2021, 10, 15) },
                new Record { Id = 7, CategoryId = 2, LastUpdate = new DateTime(2021, 10, 18) },
                new Record { Id = 8, CategoryId = 2, LastUpdate = new DateTime(2021, 10, 19) },
                new Record { Id = 9, CategoryId = 1, LastUpdate = new DateTime(2021, 10, 20) },
                new Record { Id = 10, CategoryId = 1, LastUpdate = new DateTime(2021, 10, 21) },
                new Record { Id = 11, CategoryId = 2, LastUpdate = new DateTime(2021, 10, 22) },
                new Record { Id = 12, CategoryId = 1, LastUpdate = new DateTime(2021, 10, 25) },
                new Record { Id = 13, CategoryId = 2, LastUpdate = new DateTime(2021, 10, 26) },
                new Record { Id = 14, CategoryId = 3, LastUpdate = new DateTime(2021, 10, 27) },
                new Record { Id = 15, CategoryId = 1, LastUpdate = new DateTime(2021, 10, 28) },
                new Record { Id = 16, CategoryId = 1, LastUpdate = new DateTime(2021, 10, 29) },
                new Record { Id = 17, CategoryId = 1, LastUpdate = new DateTime(2021, 11, 1) },
                new Record { Id = 18, CategoryId = 3, LastUpdate = new DateTime(2021, 11, 2) },
                new Record { Id = 19, CategoryId = 1, LastUpdate = new DateTime(2021, 11, 3) },
                new Record { Id = 20, CategoryId = 2, LastUpdate = new DateTime(2021, 11, 4) },
                new Record { Id = 21, CategoryId = 2, LastUpdate = new DateTime(2021, 11, 5) },
                new Record { Id = 22, CategoryId = 1, LastUpdate = new DateTime(2021, 11, 8) }
            );
        }
    }
}
