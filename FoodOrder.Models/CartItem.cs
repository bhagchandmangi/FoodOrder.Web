﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FoodOrder.Models
{
    public class CartItem
    {
        public CartItem(int itemId, int quantity, decimal unitPrice)
        {
            ItemId = itemId;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }
        public int Id { get; set; }
        public Guid CardId { get; set; }
        public int ItemId { get; set; } 
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        [JsonIgnore]
        public Cart Cart { get; set; }
    }
}
