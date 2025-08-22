using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesBook.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int TicketId { get; set; }
        public int InventoryId { get; set; }
        public decimal Quantity { get; set; } = 0.0M;
        public decimal Discount { get; set; } = 0.0M;
        public bool Wholesale { get; set; } = false;
        public bool Bottles { get; set; } = true;
        public bool Sale { get; set; } = true;
        public Item? Item { get; set; }
        public Ticket? Ticket { get; set; }
        public Inventory? Inventory { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public decimal GetTotalPrice() {
            if (this.Item == null) return 0;
            return this.Quantity * this.Item.PricePerUnit;
        }
    }
    

}