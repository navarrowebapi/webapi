using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    public class ProductController : ApiController
    {
        static List<Product> listaDeProdutos = new List<Product>
        { 
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 }, 
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M }, 
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M } 
        };


        public IHttpActionResult Get()
        {
            return Ok(listaDeProdutos);
        }

        public IHttpActionResult Get(int id)
        {
            var produto = listaDeProdutos.Find(x => x.Id == id);
            return Ok(produto);
        }

        // POST: api/Product
        public IHttpActionResult Post([FromBody] Product produto)
        {
            listaDeProdutos.Add(produto);
            return Ok();
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
    }
}
