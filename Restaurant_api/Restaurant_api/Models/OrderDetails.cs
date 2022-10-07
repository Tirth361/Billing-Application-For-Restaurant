using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_api.Models
{
    public class OrderDetails
    {
        [Key]
        public long OrderDetailId { get; set; }
        public long OrderMasterId { get; set; }
        public int FoodItemId { get; set; }
        public FoodItems FoodItem { get; set; }
        public decimal FoodItemPrice { get; set; }
        public int Quantity { get; set; }
    }
}
