namespace GeekShopping.CartApi.Data.ValueObjects
{
    public class CartDTO
    {
        public CartHeaderDTO CartHeader { get; set; }

        public IEnumerable<CartDetailsDTO> CartDetails { get; set; }
    }
}
