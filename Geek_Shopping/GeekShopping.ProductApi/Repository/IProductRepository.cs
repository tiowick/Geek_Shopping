using GeekShopping.ProductApi.Data.ValueObjects;

namespace GeekShopping.ProductApi.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDTO>> FindAll();
        Task<ProductDTO> FindById(long id);
        Task<ProductDTO> Create(ProductDTO DTO);
        Task<ProductDTO> Update(ProductDTO DTO);
        Task<bool> Delete(long id);
    }
}
