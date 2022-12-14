using AutoMapper;
using GeekShopping.ProductAPI.DATA_VO.ValueObjects;
using GeekShopping.ProductAPI.Model;

namespace GeekShopping.ProductAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config => {
                config.CreateMap<ProductVO,Product>().ReverseMap();
                config.CreateMap<ProductVO,Product>().ReverseMap();
                config.CreateMap<ProductVO,ProductVO>().ReverseMap();
                
            });
            return mappingConfig;
        }
    }
}