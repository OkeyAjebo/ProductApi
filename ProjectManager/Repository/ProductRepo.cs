using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectManager.Context;
using ProjectManager.Models;

namespace ProjectManager.Repository
{
    public class ProductRepo : IProductRepo
    {
        ProductDbContext context = new ProductDbContext();
        public IEnumerable<Product> GetProduct()
        {
            return context.Set<Product>().ToList();
        }
    }
}