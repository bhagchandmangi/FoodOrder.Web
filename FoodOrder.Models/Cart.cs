
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.Models
{
    public class Cart
    {
        public Guid Id { get; set; }
        public int UserId { get; set; } 
        public DateTime DateTime { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;
        public List<CartItem> CartItems { get; set; } = new List<CartItem>();
    }
}
