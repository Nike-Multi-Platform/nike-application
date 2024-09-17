using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nike_Shop_Management.MappingLayer;
using Nike_Shop_Management.DTO;

namespace Nike_Shop_Management.DAL
{
    class ProductCategoryRepository
    {
        DbContext _db;

        public ProductCategoryRepository(DbContext db)
        {
            _db = db;
        }

        internal IEnumerable<ProductCategoryDTO> GetAll()
        {
            var list = _db.category_products.Select(t => AutoMapperConfig.Mapper.Map<category_product, ProductCategoryDTO>(t)).ToList();
            if(list!=null)
            {
                return list;
            }
            return null;
        }
    }
}
