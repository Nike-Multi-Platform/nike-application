using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nike_Shop_Management.DTO
{
    class GoodsReceiptDTO
    {
        public int goods_receipt_id { get; set; }
        public int supplier_id { get; set; }
        public int user_id { get; set; }
        public double total_price { get; set; }
        public DateTime created_at { get; set; }
        public int is_handle { get; set; }
    }
}
