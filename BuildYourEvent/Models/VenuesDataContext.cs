using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

namespace BuildYourEvent.Models
{
    public class VenuesDataContext : DbContext
    {
        public VenuesDataContext(DbContextOptions<VenuesDataContext> options)
            : base(options)
        {

        }
        /*
         Must use fluent api to set a surogate key for our junction (many to many)
         tables.
             */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Venue_Types_Venues>()
                .HasKey(c => new { c.fk_Venue, c.fk_Venue_Type });

            modelBuilder.Entity<Venue_Rules_Venues>()
                .HasKey(c => new { c.fk_Venue, c.fk_Venue_Rule });

            modelBuilder.Entity<Amenities_Venues>()
              .HasKey(c => new { c.fk_Venue, c.fk_Amenity });

            modelBuilder.Entity<Event_Types_Venues>()
              .HasKey(c => new { c.fk_Venue, c.fk_Event_Type });

            modelBuilder.Entity<On_Site_Services_Venues>()
              .HasKey(c => new { c.fk_Venue, c.fk_On_Site_Service });

            modelBuilder.Entity<Styles_Venues>()
              .HasKey(c => new { c.fk_Venue, c.fk_Style });

            modelBuilder.Entity<Features_Venues>()
             .HasKey(c => new { c.fk_Venue, c.fk_Feature });
        }


        public DbSet<Bookings> Bookings { get; set; }
        public DbSet<Amenities> Amenities { get; set; }
        public DbSet<Event_Types> Event_Types { get; set; }
        public DbSet<Features> Features { get; set; }
        public DbSet<Locations> Locations { get; set; }
        public DbSet<On_Site_Services> On_Site_Services { get; set; }
        public DbSet<Styles> Styles { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Vendors> Vendors { get; set; }
        public DbSet<Venue_Rules> Venue_Rules { get; set; }
        public DbSet<Venue_Types> Venue_Types { get; set; }
        public DbSet<Venues> Venues { get; set; }
        public DbSet<Amenities_Venues> Amenities_Venues { get; set; }
        public DbSet<Event_Types_Venues> Event_Types_Venues { get; set; }
        public DbSet<Features_Venues> Features_Venues { get; set; }
        public DbSet<On_Site_Services_Venues> On_Site_Services_Venues { get; set; }
        public DbSet<Styles_Venues> Styles_Venues { get; set; }
        public DbSet<Venue_Rules_Venues> Venue_Rules_Venues { get; set; }
        public DbSet<Venue_Types_Venues> Venue_Types_Venues { get; set; }
        public DbSet<Order_States> Order_States { get; set; }
        public DbSet<Photos> Photos { get; set; }

    }
}
