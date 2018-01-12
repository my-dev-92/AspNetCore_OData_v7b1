using System;

namespace ODataService.Model
{
    public class ProductCategory
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTimeOffset Created { get; set; }
    }
}