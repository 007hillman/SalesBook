using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SalesBook.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
	public DbSet<Item> Item {get; set; }
	public DbSet<Ticket> Ticket {get; set;}
	public DbSet<ItemTicket> ItemTicket {get; set; }
		
	protected override void OnModelCreating(ModelBuilder builder){
		builder.Entity<ItemTicket>()
			.HasOne(it => it.Item)
			.WithMany(i => i.ItemTickets)
			.HasForeignKey(it => it.ItemId);
		builder.Entity<ItemTicket>()
			.HasOne(it => it.Ticket)
			.WithMany(t => t.ItemTickets)
			.HasForeignKey(it => it.TicketId);
		base.OnModelCreating(builder);
	}
}

