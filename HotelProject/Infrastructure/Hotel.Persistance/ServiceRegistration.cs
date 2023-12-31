﻿using System;
using Hotel.Application.Repositories;
using Hotel.Persistance.Contexts;
using Hotel.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Hotel.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceService(this IServiceCollection collection)
        {
            collection.AddDbContext<HotelDbContext>(opt => opt.UseNpgsql("User ID=postgres;Password=123456;Host=localhost;Port=5432;Database=HotelDb;"));
            collection.AddScoped<IAboutReadRepository,AboutReadRepository>();
            collection.AddScoped<IRoomReadRepository, RoomReadRepository>();
            collection.AddScoped<IServiceReadRepository, ServiceReadRepository>();
            collection.AddScoped<IStaffReadRepository, StaffReadRepository>();
            collection.AddScoped<ITestimonialReadRepository, TestimonialReadRepository>();
            collection.AddScoped<ISubscribeWriteRepository, SubscribeWriteRepository>();
            collection.AddScoped<IContactWriteRepository, ContactWriteRepository>();
            collection.AddScoped<IBookingWriteRepository, BookingWriteRepository>();
        }
    }
}

