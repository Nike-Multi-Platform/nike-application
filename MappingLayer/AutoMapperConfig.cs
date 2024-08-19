using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nike_Shop_Management.MappingLayer
{
    public static class AutoMapperConfig
    {
        public static IMapper Mapper { get; private set; }

        static AutoMapperConfig()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MappingProfile>(); // Cấu hình ánh xạ
            });

            Mapper = config.CreateMapper();
        }
    }
}
