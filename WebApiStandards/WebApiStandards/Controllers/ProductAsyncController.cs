using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiStandards.Modals;


namespace WebApiStandards.Controllers
{
    [Route("api/productasync")]
    public class ProductAsyncController : Controller
    {
        private readonly IEnumerable<Product> products = new List<Product>()
                                { new Product() { Id = 1, Name = "Mobile" }
                                , new Product() { Id = 2, Name = "TV" } };

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        // GET: api/ProductAsync
        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            var products2 = await Task.Run(() => products);
            return products2;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: api/ProductAsync/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<Product> Get(int id)
        {

            Task<Product> task = new Task<Product>(()=> { Thread.Sleep(10000); return products.FirstOrDefault();  });
            task.Start();

            var product = await task;
           // var product2 = task.Result;


            return product;
        }

        // POST: api/ProductAsync
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ProductAsync/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
