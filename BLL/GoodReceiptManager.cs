using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nike_Shop_Management.DAL;
using Nike_Shop_Management.DTO;
namespace Nike_Shop_Management.BLL
{
    class GoodReceiptManager
    {
        GoodReceiptRepository _goodReceiptRepository;
        public GoodReceiptManager(GoodReceiptRepository goodReceiptRepository)
        {
            _goodReceiptRepository = goodReceiptRepository;
        }
        public GoodsReceiptDTO CreateReceipt(GoodsReceiptDTO goodsReceiptDTO)
        {
            return _goodReceiptRepository.CreateReceipt(goodsReceiptDTO);
        }
        public int Update(GoodsReceiptDTO goodsReceiptDTO)
        {
            return _goodReceiptRepository.Update(goodsReceiptDTO);
        }
        
    }
}
