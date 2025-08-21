using System.ComponentModel.DataAnnotations;
using SalesBook.Models;
namespace SalesBook.Models;

public class Ticket
{
    [Key]
    public int Id { get; set; }
    public int TableNumber { get; set; }
    public string? ClientName { get; set; }
    public bool paid { get; set; } = false;
    public ICollection<Order> Orders { get; set; } = new List<Order>();   
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

}
