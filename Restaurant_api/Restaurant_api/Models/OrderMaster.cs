using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_api.Models
{
    public class OrderMaster
    {
        [Key]
        public long OrderMasterId { get; set; }
        [StringLength(75)]
        public string OrderNumber { get; set; }
        public int CustomerId { get; set; }
        public Customers Customer { get; set; }
        [StringLength(10)]
        public string PMethod { get; set; }
        public decimal GTotal { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }
        [NotMapped]
        public string DeleteOrderItemIds { get; set; }
    }
}
