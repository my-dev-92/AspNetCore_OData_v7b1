namespace ODataService.Model
{
    public class ProductDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ProductCategory Category { get; set; }
    }
}