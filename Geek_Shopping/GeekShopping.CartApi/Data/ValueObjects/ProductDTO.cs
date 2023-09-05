using GeekShopping.CartApi.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.CartApi.Data.ValueObjects
{

    public class ProductDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public String Description { get; set; }
        public string CategoryName { get; set; }
        public string imageURL { get; set; }


    }
}
