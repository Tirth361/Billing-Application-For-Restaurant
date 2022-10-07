using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_api.Models
{
    public class RestautarantDbContext : DbContext
    {
        public RestautarantDbContext(DbContextOptions<RestautarantDbContext> options): base(options)
        {

        }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<FoodItems> FoodItems { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<OrderMaster> OrderMasters { get; set; }

    }
}
