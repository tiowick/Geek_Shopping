using AutoMapper;
using GeekShopping.CartApi.Data.ValueObjects;
using GeekShopping.CartApi.Model;

namespace GeekShopping.CartApi.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMapps()
        {
            var mappingConfig =  new MapperConfiguration(config => {
                config.CreateMap<ProductDTO, Product>().ReverseMap();
                config.CreateMap<CartHeaderDTO, CartHeader>().ReverseMap();
                config.CreateMap<CartDetailsDTO, CartDetail>().ReverseMap();
                config.CreateMap<CartDTO, Cart>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
