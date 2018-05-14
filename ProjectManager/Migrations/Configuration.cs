namespace ProjectManager.Migrations
{
    using ProjectManager.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProjectManager.Context.ProductDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProjectManager.Context.ProductDbContext context)
        {
            context.Product.Add(new Product
            {
                Name = "Earpiece",
                Description = "Sound Peripheral",
                Price = 1500,
                Category = new Category { CategoryName = "System Accessories" }
            });
            context.Product.Add(new Product
            {
                Name = "Sugar",
                Description = "Provision",
                Price = 350,
                Category = new Category { CategoryName = "Beverage" }
            });
            context.Product.Add(new Product
            {
                Name = "Blazer",
                Description = "Wears",
                Price = 10000,
                Category = new Category { CategoryName = "Clothing" }
            });
        }
    }
}
