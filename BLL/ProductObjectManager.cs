
using Nike_Shop_Management.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nike_Shop_Management.DTO;
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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public int Update(ProductObjectDTO enity)
        {
            throw new NotImplementedException();
        }
    }
}
