using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nike_Shop_Management.DAL
{
    class ProductObjectRepository
    {
        private readonly DbContext _db;
        public ProductObjectRepository(DbContext db)
        {
            _db = db;
        }
    }
}
