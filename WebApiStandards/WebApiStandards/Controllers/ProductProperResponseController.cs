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
    [Route("api/productproperresponse")]
    public class ProductProperResponseController : Controller
    {
        //Use web API conventions

        //Result Types

        //Specific type
        //IActionResult
        //ActionResult<T>


        private List<Product> products = new List<Product>() { new Product() { Id = 1, Name = "Mobile" }, new Product() { Id = 2, Name = "TV" } };

        /// <summary>
        /// Get Method
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(Product), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get()
        {
            if (products != null && products.Any())
            {
                return Ok(products);
            }
            else
            {
                return NotFound();
            }
        }

        //[HttpGet("{id:int}")]
        //public Product Get(int id)
        //{
        //    return new Product();
        //}

        //[HttpPost()]
        //public void Post([FromBody] Product product)
        //{
        //    throw new NotImplementedException();
        //}

        //[HttpPut("id:int")]
        //public void Put(int id, [FromBody] Product product)
        //{
        //    throw new NotImplementedException();
        //}

        //[HttpDelete("{id:int}")]
        //public void Delete(int id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}