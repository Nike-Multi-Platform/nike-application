using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nike_Shop_Management.DTO;
using Nike_Shop_Management.DAL;
namespace Nike_Shop_Management.BLL
{
    class ProductSizeManager 
    {
        private readonly ProductSizeRepository _productSizeRepository;
        public ProductSizeManager(ProductSizeRepository productSizeRepository)
        {
            _productSizeRepository = productSizeRepository;
        }

        /// <summary>
        /// id là id của thằng product
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<ProductSizeDTO> GetProductSizesByID(int id)
        {
            return _productSizeRepository.GetProductSizesByID(id);
        }
        
        
    }
}
