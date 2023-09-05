using GeekShopping.CartApi.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.CartApi.Data.ValueObjects
{ 
    public class CartHeaderDTO 
    {
        public long id { get; set; }    
        public string UserId { get; set; }
        public string CupomCode { get; set; }
    }
}
