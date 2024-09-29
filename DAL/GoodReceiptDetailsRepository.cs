using Nike_Shop_Management.DTO;
using System;
using System.Collections.Generic;
namespace Nike_Shop_Management.DAL
{
    class GoodReceiptDetailsRepository
    {
        DbContextDataContext _db;
        public GoodReceiptDetailsRepository(DbContextDataContext db)
        {
            _db = db;

        }

        internal int Add(List<GoodReceiptDetailsDTO> list)
        {
            try
            {
                foreach (var item in list)
                {
                    _db.SaveTempImportProduct(item.good_receipt_id, item.product_id, item.product_size_id, item.import_price, item.quantity);
                }
                _db.SubmitChanges();
                return 1;

            }
            catch (Exception)
            {
                return 0;
            }

        }
        public int Save()
        {
            try
            {
                _db.ProcessImportProducts();
                _db.SubmitChanges();
                return 1;
            }
            catch (Exception)
            {

                return 0;

            }
        }
    }
}
