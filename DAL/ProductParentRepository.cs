using Nike_Shop_Management.MappingLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nike_Shop_Management.DTO;
namespace Nike_Shop_Management.DAL
{
    class ProductParentRepository
    {
        private readonly DbContext _db;

        public ProductParentRepository(DbContext db)
        {
            _db = db;
        }
        public List<ProductParentDTO> getDatasProductParent()
        {
            List<ProductParentDTO> l = _db.product_parents.Select(emp => AutoMapperConfig.Mapper.Map<product_parent, ProductParentDTO>(emp)).ToList();
            return l;
        }

        

    }
}
