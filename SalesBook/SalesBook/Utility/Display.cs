using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesBook.Models;

namespace SalesBook.Utility
{
    public class Display
    {
        public Item? _item { get; set; }
        public bool _increase { get; set; } = true;
        public int _count { get; set; }
    }
}