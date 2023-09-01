using AutoMapper;
using GeekShopping.CartApi.Model;

namespace GeekShopping.CartApi.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMapps()
        {
            var mappingConfig =  new MapperConfiguration(config => {
                //config.CreateMap<ProductDTO, Product>();
                //config.CreateMap<Product, ProductDTO>();
            });
            return mappingConfig;
        }
    }
}
