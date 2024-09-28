using Nike_Shop_Management.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nike_Shop_Management.MappingLayer;
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
