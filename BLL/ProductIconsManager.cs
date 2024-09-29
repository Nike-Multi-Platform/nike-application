﻿using Nike_Shop_Management.DAL;
using Nike_Shop_Management.DTO;
using System;
using System.Collections.Generic;
namespace Nike_Shop_Management.BLL
{
    class ProductIconsManager : IRepository<ProductIconsDTO>
    {
        ProductIconsRepository _productIconsRepository;
        public ProductIconsManager(ProductIconsRepository productIconsRepository)
        {
            _productIconsRepository = productIconsRepository;
        }

        public int Add(ProductIconsDTO entity)
        {
            return _productIconsRepository.Add(entity);
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductIconsDTO> GetAll()
        {
            return _productIconsRepository.GetAll();
        }

        public ProductIconsDTO GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public string Name()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductIconsDTO> Search(string search)
        {
            throw new NotImplementedException();
        }

        public int Update(ProductIconsDTO enity)
        {
            throw new NotImplementedException();
        }
    }
}
