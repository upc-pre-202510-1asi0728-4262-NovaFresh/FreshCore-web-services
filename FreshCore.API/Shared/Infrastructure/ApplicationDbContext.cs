using FreshCore.API.AccountSubscription.Domain.Models.Aggregates;
using FreshCore.API.AccountSubscription.Domain.Models.Entities;
using FreshCore.API.GroupManagement.Domain.Models.Entities;
using FreshCore.API.ContainerManagement.Domain.Models.Entities;
using FreshCore.API.UserProfile.Domain.Models.Entities;
using FreshCore.API.UserProfile.Domain.Models.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace FreshCore.API.Shared.Infrastructure
{
	public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
	{
		public DbSet<User> Users { get; set; }
		public DbSet<Profile> Profiles { get; set; }
		public DbSet<Account> Accounts { get; set; }
		public DbSet<Subscription> Subscriptions { get; set; }
		public DbSet<ProfilePrivilege> ProfilePrivileges { get; set; }	
		public DbSet<Group> Groups { get; set; }
		public DbSet<Location> locations { get; set; }
		public DbSet<Container> Containers { get; set; }
		public DbSet<Template> Templates { get; set; }
		public DbSet<Notification> Notifications { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Group>().Property(g => g.FacilityType).HasConversion<string>();

			modelBuilder.Entity<Group>()
				.HasOne(g => g.Location)
				.WithMany()
				.HasForeignKey(g => g.LocationId);

			modelBuilder.Entity<Container>()
				.OwnsOne(c => c.ContainerConditions);

		}

	}

}