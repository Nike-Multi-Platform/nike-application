using Nike_Shop_Management.DAL;
using Nike_Shop_Management.DTO;
using System.Collections.Generic;
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
