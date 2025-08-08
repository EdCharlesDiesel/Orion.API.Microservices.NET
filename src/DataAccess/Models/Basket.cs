

using System;
using System.Collections.Generic;

namespace Orion.DataAccess.Models
{
    public class Basket
    {
        public Guid UserId { get; set; } 
        public List<BasketItem>? Items { get; set; } 
        public decimal? TotalPrice { get; set; } 
        public string? Currency { get; set; } 
        public bool IsCheckedOut { get; set; } 
        
    }
}
