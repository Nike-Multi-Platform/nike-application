using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nike_Shop_Management.DAL;
using Nike_Shop_Management.DTO;
namespace Nike_Shop_Management.BLL
{
    class SubCategoryManager : IRepository<SubCategoryDTO>
    {
        SubcategoryRepository _subcategoryRepository;
        public SubCategoryManager(SubcategoryRepository subcategoryRepository)
        {
            _subcategoryRepository = subcategoryRepository;
        }
        public int Add(SubCategoryDTO entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SubCategoryDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public SubCategoryDTO GetByID(int id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<SubCategoryDTO> GetAllByID(int id)
        {
            return _subcategoryRepository.GetAllByID(id);
        }
        public string Name()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SubCategoryDTO> Search(string search)
        {
            throw new NotImplementedException();
        }

        public int Update(SubCategoryDTO enity)
        {
            throw new NotImplementedException();
        }
    }
}
