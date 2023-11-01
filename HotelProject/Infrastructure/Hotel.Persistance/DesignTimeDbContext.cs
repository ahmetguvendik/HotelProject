using System;
using Hotel.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Hotel.Persistance
{
    public class DesignTimeDbContext : IDesignTimeDbContextFactory<HotelDbContext>
    {

        public HotelDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<HotelDbContext> dbContextOptions = new();
            dbContextOptions.UseNpgsql("User ID=postgres;Password=123456;Host=localhost;Port=5432;Database=HotelDb;");
            return new(dbContextOptions.Options);
        }
    }
}

