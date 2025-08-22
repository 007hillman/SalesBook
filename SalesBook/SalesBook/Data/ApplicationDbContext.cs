using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SalesBook.Models;
namespace SalesBook.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
	public DbSet<Item> Items {get; set; }
	public DbSet<Ticket> Tickets {get; set;}
	public DbSet<Order> Orders { get; set; }
	public DbSet<Payment> Payments { get; set; }
	public DbSet<Inventory> Inventories { get; set; }
	protected override void OnModelCreating(ModelBuilder builder)
	{
		builder.Entity<Order>()
			.HasOne(o => o.Item)
				.WithMany()
					.HasForeignKey(o => o.ItemId)
						.OnDelete(DeleteBehavior.Restrict);

		builder.Entity<Order>()
			.HasOne(o => o.Ticket)
				.WithMany(t => t.Orders)
					.HasForeignKey(o => o.TicketId)
						.OnDelete(DeleteBehavior.Cascade);

		builder.Entity<Order>()
			.HasOne(o => o.Inventory)
			.WithMany(t => t.Orders)
			.HasForeignKey(o => o.InventoryId)
			.OnDelete(DeleteBehavior.Cascade);
		base.OnModelCreating(builder);
	}
}

