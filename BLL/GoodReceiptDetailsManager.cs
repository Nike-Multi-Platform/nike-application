﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nike_Shop_Management.DAL;
using Nike_Shop_Management.DTO;
namespace Nike_Shop_Management.BLL
{
    class GoodReceiptDetailsManager
    {
        GoodReceiptDetailsRepository _goodReceiptDetailsRepository;
        public GoodReceiptDetailsManager(GoodReceiptDetailsRepository goodReceiptDetailsRepository)
        {
            _goodReceiptDetailsRepository = goodReceiptDetailsRepository;
        }
        
        public int Add(List<GoodReceiptDetailsDTO> list)
        {
            return _goodReceiptDetailsRepository.Add(list);
        }
    }
}