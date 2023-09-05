using GeekShopping.CartApi.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.CartApi.Data.ValueObjects
{
   
    public class CartDetailsDTO
    {
        public long id { get; set; }
        public long CartHeaderId { get; set; }
        public CartHeaderDTO CartHeader { get; set; }
        public long ProductId { get; set;}
        public ProductDTO Product { get; set; }
        public int Count { get; set; }
    }
}
