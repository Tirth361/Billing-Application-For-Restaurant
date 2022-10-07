using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_api.Models
{
    public class Customers
    {
        [Key]
        public int CustomerId { get; set; }
        [StringLength(100)]
        public string CusomerName { get; set; }
    }
}
