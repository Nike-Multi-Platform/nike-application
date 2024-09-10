using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nike_Shop_Management.MappingLayer;
using Nike_Shop_Management.DTO;
namespace Nike_Shop_Management.DAL
{
    class ProductObjectRepository
    {
        private readonly DbContext _db;
        public ProductObjectRepository(DbContext db)
        {
            _db = db;
        }
        public List<ProductObjectDTO> GetAll()
        {
            List<ProductObjectDTO> list = _db.product_objects.Select(temp => AutoMapperConfig.Mapper.Map<product_object, ProductObjectDTO>(temp)).ToList();
            return list;
        }
    }
}
