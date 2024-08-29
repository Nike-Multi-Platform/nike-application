using AutoMapper;
using Nike_Shop_Management.DAL;
using Nike_Shop_Management.DTO;

namespace Nike_Shop_Management.MappingLayer
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<user_account, UserAccountDTO>();
            CreateMap<UserAccountDTO, user_account>();

            CreateMap<ProductParentDTO, product_parent>();
            CreateMap<product_parent, ProductParentDTO>();

        }
    }
}
