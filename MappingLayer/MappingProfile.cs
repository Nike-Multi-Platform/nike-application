using AutoMapper;
using Nike_Shop_Management.DTO;
using Nike_Shop_Management.DAL;

namespace Nike_Shop_Management.MappingLayer
{
    public class MappingProfile : Profile
    {
        // ánh xạ DTO -> ENTIRY
        public MappingProfile()
        {
            CreateMap<UserAccountDTO, user_account>();
            CreateMap<user_account, UserAccountDTO>();

            CreateMap<ProductParentDTO, product_parent>();
            CreateMap<product_parent, ProductParentDTO>();

            // ánh xạ map
            CreateMap<ProductObjectDTO, product_object>();
            CreateMap<product_object, ProductObjectDTO>();

            CreateMap<product, ProductDTO>();
            CreateMap<ProductDTO, product>();

            CreateMap<product_icon, ProductIconsDTO>();
            CreateMap<ProductIconsDTO, product_icon>();


            CreateMap<ProductCategoryDTO, category_product>();
            CreateMap<category_product, ProductCategoryDTO>();
        }
    }
}
