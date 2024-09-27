using Nike_Shop_Management.DAL;
using Nike_Shop_Management.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nike_Shop_Management.BLL
{
    class SizeManager : IRepository<SizeDTO>
    {
        SizeRepository _sizeRepository;
        public SizeManager(SizeRepository sizeRepository)
        {
            _sizeRepository = sizeRepository;
        }

        public int Add(SizeDTO entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SizeDTO> GetAll()
        {
            return _sizeRepository.GetAll();
        }

        public SizeDTO GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public string Name()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SizeDTO> Search(string search)
        {
            throw new NotImplementedException();
        }

        public int Update(SizeDTO enity)
        {
            throw new NotImplementedException();
        }
    }
}
