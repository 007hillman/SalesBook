using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesBook.Models
{
    public class Order
    {
        public int Id { get; set;  }
        public int ItemId { get; set; }
        public int TicketId { get; set; }
        public decimal Quantity { get; set; } = 0.0M;
        public Item? Item { get; set; } 
        public Ticket? Ticket { get; set; } 
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}