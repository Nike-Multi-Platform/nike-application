using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nike_Shop_Management.DAL
{
    public interface IRepository<T>
    {
        int Add(T entity);
        int Delete(int id);
        int Update(T enity);
        IEnumerable<T> Search(string search);
        IEnumerable<T> GetAll();
        T GetByID(int id);
        /// <summary>
        /// trả về cái tên nghiệp vụ
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        string Name();
    }
}
