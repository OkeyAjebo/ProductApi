using ProjectManager.Models;
using ProjectManager.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectManager.Controllers.API
{
    [RoutePrefix("api/product")]
    public class ProductApiController : ApiController
    {
        private readonly ProductRepo repo;
        public ProductApiController()
        {
            repo = new ProductRepo();
        }
        [Route("list")]
        [HttpGet]
        public HttpResponseMessage ProductFetch()
        {
            try
            {
                var getProduct = repo.GetProduct();
                return Request.CreateResponse<IEnumerable<Product>>(HttpStatusCode.OK, getProduct);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            
            
        }
    }
}
