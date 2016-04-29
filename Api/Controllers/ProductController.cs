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
        List<Product> listaDeProdutos = new List<Product>();
        

        // GET: api/Product
        public IHttpActionResult Get()
        {
            var produto1 = new Product{ Id = 1, Name = "Placa de Rede",
                Category = "Hardware", Price = 120m};

            var produto2 = new Product { Id = 2, Name = "Placa mãe", 
                Category = "Hardware", Price = 480m };
            
            var produto3 = new Product { Id = 3, Name = "Antivirus",
                Category = "Software", Price = 80m };

            listaDeProdutos.Add(produto1);
            listaDeProdutos.Add(produto2);
            listaDeProdutos.Add(produto3);

            return Ok(listaDeProdutos);
        }

        // GET: api/Product/5
        public IHttpActionResult Get(int id)
        {
            var produto1 = new Product
            {
                Id = 1,
                Name = "Placa de Rede",
                Category = "Hardware",
                Price = 120m
            };

            var produto2 = new Product
            {
                Id = 2,
                Name = "Placa mãe",
                Category = "Hardware",
                Price = 480m
            };

            var produto3 = new Product
            {
                Id = 3,
                Name = "Antivirus",
                Category = "Software",
                Price = 80m
            };

            listaDeProdutos.Add(produto1);
            listaDeProdutos.Add(produto2);
            listaDeProdutos.Add(produto3);

            var produto = listaDeProdutos.Find(x => x.Id == id);
            return Ok(produto);
        }

        // POST: api/Product
        public void Post([FromBody]string value)
        {
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
