﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nike_Shop_Management.DTO
{
    class ProductSizeDTO
    {
        public int product_size_id { get; set; }
        public int product_id { get; set; }
        public int size_id { get; set; }
        public int product_quantity { get; set; }

        public ProductDTO Product_details { get; set; }


    }
}
