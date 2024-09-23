using Nike_Shop_Management.DAL;
using Nike_Shop_Management.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nike_Shop_Management.BLL
{
    class ProductColorManager : IRepository<ProductColorsDTO>
    {
        private readonly ProductColorRepository _productColorRepository;
        public ProductColorManager(ProductColorRepository productColorRepository)
        {
            _productColorRepository = productColorRepository;
        }

        public int Add(ProductColorsDTO entity)
        {
            return _productColorRepository.Add(entity);
        }

        public int Delete(int id)
        {
            return _productColorRepository.Delete(id);
        }

        public IEnumerable<ProductColorsDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public ProductColorsDTO GetByID(int id)
        {
            return _productColorRepository.GetByID(id);
        }

        public string Name()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductColorsDTO> Search(string search)
        {
            throw new NotImplementedException();
        }

        public int Update(ProductColorsDTO enity)
        {
            return _productColorRepository.Update(enity);
        }

       public ProductParentDTO BelongsTo()
        {
            return _productColorRepository.BelongsTo();
        }

        internal List<ProductSizeDTO> GetProductSizesByID(int product_id)
        {
            return _productColorRepository.GetProductSize(product_id);
        }
        public int DeleteProductSize(int product_size_id)
        {
            return _productColorRepository.DeleteProductSize(product_size_id);
        }
        public List<SupplierDTO> GetSuppliers(int suppler_id)
        {
            return _productColorRepository.GetSuppliers(suppler_id);
        }
    }
}
