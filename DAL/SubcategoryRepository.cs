using Nike_Shop_Management.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nike_Shop_Management.MappingLayer;
namespace Nike_Shop_Management.DAL
{
    class SubcategoryRepository
    {
        DbContext _db;
        public SubcategoryRepository(DbContext db)
        {
            _db = db;
        }

        internal IEnumerable<SubCategoryDTO> GetAllByID(int id)
        {
            var list = _db.sub_categories.Where(t => t.categories_id == id).Select(t => AutoMapperConfig.Mapper.Map<sub_category,SubCategoryDTO>(t)).ToList();
            if(list!=null)
            {
                return list;
            }
            return null;
        }
    }
}
