using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesBook.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public decimal Amount { get; set; } = 0.0M;
        public int TicketId { get; set; }
        public Ticket? Ticket { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now; 
    }
}