using Nike_Shop_Management.DAL;
using Nike_Shop_Management.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nike_Shop_Management.BLL
{
    class ProductColorManager : IRepository<ProductDTO>
    {
        private readonly ProductColorRepository _productColorRepository;
        public ProductColorManager(ProductColorRepository productColorRepository)
        {
            _productColorRepository = productColorRepository;
        }

        public int Add(ProductDTO entity)
        {
            return _productColorRepository.Add(entity);
        }

        public int Delete(int id)
        {
            return _productColorRepository.Delete(id);
        }

        public IEnumerable<ProductDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public ProductDTO GetByID(int id)
        {
            return _productColorRepository.GetByID(id);
        }

        public string Name()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductDTO> Search(string search)
        {
            throw new NotImplementedException();
        }

        public int Update(ProductDTO enity)
        {
            return _productColorRepository.Update(enity);
        }

       public ProductParentDTO BelongsTo()
        {
            return _productColorRepository.BelongsTo();
        }

        internal object GetProductSizesByID(int product_id)
        {
            return _productColorRepository.GetProductSizesByID(product_id);
        }
    }
}
