using System.ComponentModel.DataAnnotations;
using SalesBook;
namespace SalesBook;

public class Ticket
{
    [Key]
    public int Id { get; set; }
    public int TableNumber { get; set; }
    public string? ClientName { get; set; }
    public ICollection<ItemTicket> ItemTickets {get; set;} = [];   
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

}
