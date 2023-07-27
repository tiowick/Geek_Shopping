namespace GeekShopping.web.Models
{
    public class ProductModel
    {
        public long id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public String Description { get; set; }
        public string CategoryName { get; set; }
        public string imageURL { get; set; }
    }
}
