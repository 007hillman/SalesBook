using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesBook.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public ICollection<Order> Orders = new List<Order>();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}