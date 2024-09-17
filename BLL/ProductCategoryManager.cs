using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nike_Shop_Management.DAL;
using Nike_Shop_Management.DTO;
namespace Nike_Shop_Management.BLL
{
    class ProductCategoryManager : IRepository<ProductCategoryDTO>
    {
        ProductCategoryRepository _productCategoryRepository;
        public ProductCategoryManager(ProductCategoryRepository productCategoryRepository)
        {
            _productCategoryRepository = productCategoryRepository;
        }
        public int Add(ProductCategoryDTO entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductCategoryDTO> GetAll()
        {
            return _productCategoryRepository.GetAll();
        }

        public ProductCategoryDTO GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public string Name()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductCategoryDTO> Search(string search)
        {
            throw new NotImplementedException();
        }

        public int Update(ProductCategoryDTO enity)
        {
            throw new NotImplementedException();
        }
    }
}
