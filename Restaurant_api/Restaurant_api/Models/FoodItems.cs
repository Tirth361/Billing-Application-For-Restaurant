using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_api.Models
{
    public class FoodItems
    {
        [Key]
        public int FoodItemId { get; set; }
        [StringLength(100)]
        public string FoodItemName { get; set; }
        public decimal Price { get; set; }
    }
}
