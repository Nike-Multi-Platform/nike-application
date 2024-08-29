using Nike_Shop_Management.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nike_Shop_Management.BLL
{
    class ProductObjectManager
    {
        private readonly ProductObjectRepository objectRepository;

        public ProductObjectManager(ProductObjectRepository _objectRepobsitory)
        {
            objectRepository = _objectRepobsitory;
        }

    }
}
