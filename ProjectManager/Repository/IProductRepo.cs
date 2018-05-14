using ProjectManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Repository
{
    public interface IProductRepo
    {
        IEnumerable<Product> GetProduct();
    }
}
