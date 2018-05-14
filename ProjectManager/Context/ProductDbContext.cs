using ProjectManager.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectManager.Context
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext() : base($"name={typeof(ProductDbContext)}")
        {

        }
        public DbSet<Product> Product { get; set; }
    }
}