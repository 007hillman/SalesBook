using System.ComponentModel.DataAnnotations;
using SalesBook.Models;
namespace SalesBook.Models;

public class Ticket
{
    [Key]
    public int Id { get; set; }
    public int TableNumber { get; set; }
    public string? ClientName { get; set; }
    public bool TransactionCompleted { get; set; } = false;
    public decimal AmountPaid { get; set; } = 0.0M;
    //Child relations
    public ICollection<Order> Orders { get; set; } = new List<Order>();
    public ICollection<Payment> Payments { get; set; } = new List<Payment>();
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public decimal GetTotal()
    {
        decimal total = 0;
        var orders = this.Orders;
        if (orders.Count > 0)
        {
            foreach (var order in orders)
            {
                total += order.GetTotalPrice();
            }
        }
            return total;
    }
}
