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
        public List<ProductParentDTO> getProductParents()
        {
            List<ProductParentDTO> l = _db.product_parents.Select(emp => AutoMapperConfig.Mapper.Map<product_parent, ProductParentDTO>(emp)).ToList();
            return l;
        }

        public List<ProductDTO> getProductColor(int product_parent_id)
        {
            List<product> products = _db.products.Where(emp => (int)emp.product_parent_id == product_parent_id).ToList();
            List<ProductDTO> l = new List<ProductDTO>();
            foreach (product p in products)
            {
                l.Add(AutoMapperConfig.Mapper.Map<product, ProductDTO>(p));
            }

            return l;
        }

    }
}
