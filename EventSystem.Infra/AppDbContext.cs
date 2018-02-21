﻿using EventSystem.Domain.Entities;
using EventSystem.Shared.Entities;
using Flunt.Notifications;
using Microsoft.EntityFrameworkCore;

namespace EventSystem.Infra
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{}
		
		
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Ignore<Notifiable>();
			modelBuilder.Ignore<Notification>();
			modelBuilder.Entity<Entity>()
				.Ignore(e => e.Notifications)
				.Ignore(e => e.Valid)
				.Ignore(e => e.Invalid);
		}

		public DbSet<User> Users { get; set; }
		public DbSet<Administrator> Administrators { get; set; }
		public DbSet<PointOfSale> PointOfSales { get; set; }
		public DbSet<EventAdministrator> EventAdministrators { get; set; }
	}
}