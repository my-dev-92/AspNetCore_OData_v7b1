using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using ODataService.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ODataService.Controllers
{
    [EnableQuery]
    public class ProductsController : ODataController
    {
        private List<Product> products = new List<Product>()
        {
            new Product()
            {
                ID = 1,
                Name = "Doshik",
                Category = new ProductCategory{ ID=10, Name="FastFood", Created=DateTimeOffset.Now }
            },
            new Product()
            {
                ID = 2,
                Name = "Pepsi",
                Category = new ProductCategory{ ID=30, Name="Cool", Created=DateTimeOffset.Now }
            }
        };

        public List<Product> Get()
        {
            return products;
        }

        [ODataRoute("Products({Id})")]
        public IActionResult GetById(int Id)
        {
            var item = products.FirstOrDefault(x => x.ID == Id);
            return Ok(item);
        }

        [ODataRoute("Products({id})")]
        public IActionResult Put(int id, [FromBody] Product item)
        {
            if (item == null) return BadRequest();

            return Ok(item);
        }

        public IActionResult Post([FromBody] List<Product> dtos)
        {
            if (dtos == null) return BadRequest();

            return Ok(dtos);
        }
    }
}