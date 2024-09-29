using AutoMapper;

namespace Nike_Shop_Management.MappingLayer
{
    public static class AutoMapperConfig
    {
        public static IMapper Mapper { get; private set; }

        static AutoMapperConfig()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            Mapper = config.CreateMapper();
        }
    }
}
