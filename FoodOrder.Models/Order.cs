﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.Models
{
    public class Order
    {

        public string Id { get; set; }
        public int UserId { get; set; }
        public string PaymentId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public ICollection<OrderItem> OrderItems { get; set; } = 
            new HashSet<OrderItem>();
        public string Locality { get; set; }
        public string PhoneNumber { get; set; }
    }
}
