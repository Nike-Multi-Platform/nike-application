using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nike_Shop_Management.DAL;
using Nike_Shop_Management.DTO;
namespace Nike_Shop_Management.BLL
{
    class ProductParentManager
    {
        private readonly ProductParentRepository _productParentRepository;

        public ProductParentManager(ProductParentRepository productParentRepository)
        {
            _productParentRepository = productParentRepository;
        }

        public List<ProductParentDTO> GetDatasProductParent()
        {
            return _productParentRepository.getDatasProductParent();
        }
    }
}
