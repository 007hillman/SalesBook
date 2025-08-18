using SalesBook.Data;
using Microsoft.EntityFrameworkCore;
namespace SalesBook;

public class ItemTicket
{
	public int Id {get;set;}
	public int ItemId {get; set;}
	public Item Item {get; set; } = new Item();
	
	public int TicketId{get; set;}
	public Ticket Ticket {get; set;} = new Ticket();
	public decimal Quantity {get; set; } = 0.0M;
	public DateTime CreatedAt {get; set; } = DateTime.UtcNow;
	public DateTime UpdatedAt {get; set; } = DateTime.UtcNow;

        
	public decimal GetTotalPrice(decimal unit_price){
		 return unit_price*Quantity;
	}
	
	
}
