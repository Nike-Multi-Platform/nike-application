using Nike_Shop_Management.DAL;
using Nike_Shop_Management.DTO;
using System;
using System.Collections.Generic;
namespace Nike_Shop_Management.BLL
{
    class ProductObjectManager : IRepository<ProductObjectDTO>
    {
        private readonly ProductObjectRepository objectRepository;

        public ProductObjectManager(ProductObjectRepository _objectRepobsitory)
        {
            objectRepository = _objectRepobsitory;
        }

        public int Add(ProductObjectDTO entity)
        {
            return objectRepository.Add(entity);
        }

        public int Delete(int id)
        {
            return objectRepository.Delete(id);
        }

        public IEnumerable<ProductObjectDTO> GetAll()
        {
            return objectRepository.GetAll();
        }

        public ProductObjectDTO GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public string Name()
        {
            return "Product Object";
        }

        public IEnumerable<ProductObjectDTO> Search(string search)
        {
            return objectRepository.Search(search);
        }

        public int Update(ProductObjectDTO enity)
        {
            return objectRepository.Update(enity);
        }
    }
}
