using Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Graph.Models;
using System;

namespace Data
{

	public class DataContext : DbContext
	{

		public DbSet<Guest> Guests { get; set; }
		public DbSet<Reservation> Reservations { get; set; }
		public DbSet<Core.Room> Rooms { get; set; }
        //public DataContext(DbContextOptions<DataContext> options): base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=sample_db");
        }
    }
}



