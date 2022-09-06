using System;
using Microsoft.EntityFrameworkCore;

namespace dotnet_rpg.Data
{
    public class DataContext : DbContext
    {
       public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Character> Characters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>().HasData(
                new Character
                {
                    Id = 1,
                    Name = "Frodo",
                    Class = RpgClass.Knight,
                    HitPoints = 100,
                    Strength = 15,
                    Defense = 10,
                    Intelligence = 10
                },
                new Character
                {
                    Id = 2,
                    Name = "Raistlin",
                    Class = RpgClass.Mage,
                    HitPoints = 100,
                    Strength = 5,
                    Defense = 5,
                    Intelligence = 20
                }
            );
        }
    }
}

