using GeekShopping.CartApi.Data.ValueObjects;

namespace GeekShopping.CartApi.Repository
{
    public interface ICartRepostory
    {
        Task<CartDTO> FindCartByUserId (string userId);
        Task<CartDTO> SaveOrUpdateCart(CartDTO cart);
        Task<bool> RemoveFromCart(long cartDetailsId);
        Task<bool> ApplyCupom(string userId, string cupomCode);
        Task<bool> RemoveCupom(string userId);
        Task<bool> ClearCart(string userId);
    }
}
