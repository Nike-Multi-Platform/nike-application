using Nike_Shop_Management.DTO;
using Nike_Shop_Management.MappingLayer;
using System.Collections.Generic;
using System.Linq;
namespace Nike_Shop_Management.DAL
{
    class SupplierRepository
    {
        DbContextDataContext _db;
        public SupplierRepository(DbContextDataContext db)
        {
            _db = db;
        }

        internal IEnumerable<SupplierDTO> GetAll()
        {
            var list = _db.suppliers.Select(t => AutoMapperConfig.Mapper.Map<supplier, SupplierDTO>(t)).ToList();
            return list;
        }
    }
}
