using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GeekShopping.CartApi.Data.ValueObjects
{
    public class ProductDTO
    {
        public long id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public String Description { get; set; }
        public string CategoryName { get; set; }
        public string imageURL { get; set; }

    }
}
