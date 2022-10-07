using Restaurant_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_api.Data
{
    public class Seed
    {
        public static async Task SeedData(RestautarantDbContext context)
        {
            if (!context.Customers.Any())
            {
                var customers = new List<Customers>
                {
                    new Customers
                    {
                        CusomerName  = "Bob"
                    },
                    new Customers
                    {
                        CusomerName = "Jack"
                    },
                    new Customers
                    {
                        CusomerName = "Jasmin"
                    },
                    new Customers
                    {
                        CusomerName = "Tom"
                    }
                };
                await context.Customers.AddRangeAsync(customers);
                await context.SaveChangesAsync();
            }
            if (!context.FoodItems.Any())
            {
                var foodItems = new List<FoodItems>
                {
                    new FoodItems
                    {
                        FoodItemName = "Burger",
                        Price = 10
                    },
                    new FoodItems
                    {
                        FoodItemName = "Pizza",
                        Price = 20
                    },new FoodItems
                    {
                        FoodItemName = "Hotdog",
                        Price = 8
                    },new FoodItems
                    {
                        FoodItemName = "French fries",
                        Price = 7
                    },new FoodItems
                    {
                        FoodItemName = "Pasta",
                        Price = 15
                    },new FoodItems
                    {
                        FoodItemName = "Cake",
                        Price = 11
                    },new FoodItems
                    {
                        FoodItemName = "Italian Pizza",
                        Price = 20
                    },
                };
                await context.FoodItems.AddRangeAsync(foodItems);
                await context.SaveChangesAsync();
            }
        }
    }
}
