using System;
using Hotel.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hotel.Persistance.Contexts
{
	public class HotelDbContext : DbContext
	{
        public HotelDbContext(DbContextOptions options) : base(options) { }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Booking> Bookings { get; set; }    
    }
}

