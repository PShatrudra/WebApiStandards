using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiStandards.Modals;

namespace WebApiStandards.Controllers
{
    /// <summary>
    /// Product Class
    /// </summary>
    // [Produces("application/json")]
    [Route("api/products")]
    public class ProductController : Controller
    {
        /// <summary>
        /// Get Method
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return new List<Product>();
        }

        [HttpGet("{id:int}")]
        public Product Get(int id)
        {
            return new Product();
        }

        [HttpPost()]
        public void Post([FromBody] Product product)
        {
            throw new NotImplementedException();
        }

        [HttpPut("id:int")]
        public void Put(int id, [FromBody] Product product)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id:int}")]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}