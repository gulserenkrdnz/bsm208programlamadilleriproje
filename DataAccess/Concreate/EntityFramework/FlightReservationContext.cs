using Entities.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concreate.EntityFramework
{
    public class FlightReservationContext : DbContext //DbConext EntityFramework'ten geliyor
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=FlightReservation;Trusted_Connection=true");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Firm> Firms { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Agency> Agencies { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Seat> Seats{ get; set; }

    }
}
