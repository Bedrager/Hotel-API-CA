using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.EntityConfiguration;

namespace Persistence.Context
{
    class HotelContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Checkin> Checkins { get; set; }
        public DbSet<CategoryPrice> CategoryPrices { get; set; }

        public HotelContext(DbContextOptions<HotelContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new RoomConfiguration());
            modelBuilder.ApplyConfiguration(new GuestConfiguration());
            modelBuilder.ApplyConfiguration(new CheckinConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryPriceConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
