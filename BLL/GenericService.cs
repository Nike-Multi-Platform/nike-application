﻿using Nike_Shop_Management.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nike_Shop_Management.BLL
{
    public class GenericService<T> where T : class
    {
        private readonly IRepository<T> _repository;

        public GenericService(IRepository<T> repository)
        {
            _repository = repository;
        }

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public string Name()
        {
            return _repository.Name();
        }
        public T GetById(int id)
        {
            return _repository.GetByID(id);
        }

        public int Add(T entity)
        {
           return _repository.Add(entity);
        }

        public int Update(T entity)
        {
            return _repository.Update(entity);
        }

        public int Delete(int id)
        {
            return _repository.Delete(id);
        }
        
    }

}
