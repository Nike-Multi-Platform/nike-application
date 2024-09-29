﻿using Nike_Shop_Management.DTO;
using Nike_Shop_Management.MappingLayer;
using System.Collections.Generic;
using System.Linq;
namespace Nike_Shop_Management.DAL
{
    class SubcategoryRepository
    {
        DbContextDataContext _db;
        public SubcategoryRepository(DbContextDataContext db)
        {
            _db = db;
        }

        internal IEnumerable<SubCategoryDTO> GetAllByID(int id)
        {
            var list = _db.sub_categories.Where(t => t.categories_id == id).Select(t => AutoMapperConfig.Mapper.Map<sub_category, SubCategoryDTO>(t)).ToList();
            if (list != null)
            {
                return list;
            }
            return null;
        }
    }
}
