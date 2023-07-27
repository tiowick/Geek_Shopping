using GeekShopping.web.Models;

namespace GeekShopping.web.Services.IServices
{
    public interface IProductInterface
    {
        Task<IEnumerable<ProductModel>> FindAllProducts();
        Task<ProductModel> ProductById(long id);
        Task<ProductModel> CreateProduct(ProductModel model);
        Task<ProductModel> UpdateProduct(ProductModel model);
        Task <bool>DeleteProduct(long id);
    }
}
