using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nike_Shop_Management.DTO
{
    class ProductImgDTO
    {
        int id, product_id;
        string img;

        public int Id { get => id; set => id = value; }
        public int Product_id { get => product_id; set => product_id = value; }
        public string Img { get => img; set => img = value; }
    }
}
