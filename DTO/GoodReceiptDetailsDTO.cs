using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nike_Shop_Management.DTO
{
    class GoodReceiptDetailsDTO
    {
        public int good_receipt_id { get; set; }
        public int product_id { get; set; }
        public int import_price { get; set; }
        public int total_price { get; set; }
        public int product_size_id { get; set; }
    }
}
