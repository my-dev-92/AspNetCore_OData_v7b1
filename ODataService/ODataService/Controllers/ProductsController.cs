using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using ODataService.Model;
using System;
using System.Collections.Generic;

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


        [HttpPut("Products({ID})")]
        public IActionResult Put([FromBody]Product item)
        {
            return Ok(item);
        }
    }
}