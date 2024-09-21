using Nike_Shop_Management.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nike_Shop_Management.MappingLayer;
using Nike_Shop_Management.DTO;
namespace Nike_Shop_Management.DAL
{
    class ProductCategoriesRepository
    {
        private readonly DbContext _db;
        public ProductCategoriesRepository(DbContext db)
        {
            _db = db;
        }

        internal IEnumerable<ProductCategoriesDTO> GetProductCategoriesByID(int id)
        {
            var list = _db.categories.Where(t => t.product_object_id == id).Select(t => AutoMapperConfig.Mapper.Map<category, ProductCategoriesDTO>(t)).ToList();
            if(list!=null)
            {
                return list;
            }
            return null;
        }

        internal IEnumerable<ProductCategoriesDTO> GetAll()
        {
            var list = _db.categories.Select(t => AutoMapperConfig.Mapper.Map<category, ProductCategoriesDTO>(t)).ToList();
            if (list != null)
            {
                return list;
            }
            return null;
        }
    }
}
