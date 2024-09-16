using Nike_Shop_Management.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nike_Shop_Management.MappingLayer;
namespace Nike_Shop_Management.DAL
{
    class ProductIconsRepository
    {
        DbContext _db;
        public ProductIconsRepository( DbContext db)
        {
            _db = db;
        }

        internal int Add(ProductIconsDTO entity)
        {
            try
            {
                var item = AutoMapperConfig.Mapper.Map<ProductIconsDTO, product_icon>(entity);
                _db.product_icons.InsertOnSubmit(item);
                _db.SubmitChanges();
                return 1;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        internal IEnumerable<ProductIconsDTO> GetAll()
        {
            var list = _db.product_icons.Select(t => AutoMapperConfig.Mapper.Map<product_icon, ProductIconsDTO>(t)).ToList();
            if(list!=null)
            {
                return list;
            }
            return null;
        }
    }
}
