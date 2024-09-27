using Nike_Shop_Management.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nike_Shop_Management.MappingLayer;
namespace Nike_Shop_Management.DAL
{
    class SizeRepository
    {
        private DbContextDataContext _db;
        public SizeRepository(DbContextDataContext db)
        {
            _db = db;
        }

        internal IEnumerable<SizeDTO> GetAll()
        {
            var list = _db.sizes.Select(t => AutoMapperConfig.Mapper.Map<size, SizeDTO>(t)).ToList();
            return list;
        }

    }
}
