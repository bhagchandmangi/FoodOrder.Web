using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.Models
{
    public class Address
    {
        public Address(string street, string locolity, string city, string zipcode)
        {
            Street = street;
            Locolity = locolity;
            City = city;
            Zipcode = zipcode;
        }

        public int Id { get; set; }
        public string Street { get; set; }
        public string Locolity { get; set;}
        public string City { get; set;}
        public string Zipcode { get; set;}
        public string PhoneNumber { get; set;}
        public int UserId { get; set;}
    }
}
