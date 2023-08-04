using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.Models
{
    public class User : IdentityRole<int>
    {
        public string Name { get; set; }
        [NotMapped]
        public string[] Role { get; set; }
    }
}
